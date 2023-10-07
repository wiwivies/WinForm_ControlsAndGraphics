using System.Reflection;
using WinForm_ControlsAndGraphics.Domain;
using System.IO;
using System.Xml;
using System.Text;

namespace WinForm_ControlsAndGraphics
{
    public partial class Form1 : Form
    {
        List<Good> goods = new List<Good>();
        public Form1() 
        {
            InitializeComponent();
            NUD_Amount.BackColor = Color.DarkGray;
        }

        private void NameChanged(object sender, EventArgs e) 
        {
            if (tb_GoodName.Text.Length > 0)
            {
                NUD_Amount.Enabled = true;
                NUD_Amount.BackColor = Color.White;
            }
            else
            {
                NUD_Amount.Value = 0;
                NUD_Amount.Enabled = false;
                NUD_Amount.BackColor = Color.DarkGray;
            }
        }

        private void AmountChanged(object sender, EventArgs e) 
        {
            if (NUD_Amount.Value > 0)
            {
                tb_PricePerOne.Enabled = true;
                tb_PriceAll.Enabled = true;
            }
            else
            {
                tb_PricePerOne.Enabled = false;
                tb_PriceAll.Enabled = false;
            }
        }

        private void AddGood_Click(object sender, EventArgs e) 
        {

            try
            {
                if (tb_GoodName.Text.Length == 0)
                {
                    throw new Exception("Name is empty");
                }
                if (NUD_Amount.Value == 0)
                {
                    throw new Exception("Amount is 0");
                }
                if (tb_PricePerOne.Text.Length == 0)
                {
                    throw new Exception("Price is empty");
                }
                if (tb_Desc.Text.Length == 0)
                {
                    throw new Exception("Description is empty");
                }
                if (dateTimePicker.Value > DateTime.Now)
                {
                    throw new Exception("Date is in future");
                }

                var duplicateGood = goods.FirstOrDefault(good =>
                    good.Name == tb_GoodName.Text);

                if (duplicateGood != null)
                {
                    throw new Exception("Данный продукт уже существует.");
                }

                // Если продукта с такими же характеристиками нет, то добавляем его
                var good = new Good(tb_GoodName.Text, tb_Desc.Text, (int)NUD_Amount.Value, decimal.Parse(tb_PricePerOne.Text), dateTimePicker.Value);
                goods.Add(good);
                listOfGoods.Items.Clear();
                listOfGoods.Items.AddRange(goods.ToArray());
                listOfGoods.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PricePerOneChanged(object sender, EventArgs e) 
        {
            tb_PriceAll.Text = (NUD_Amount.Value * decimal.Parse(tb_PricePerOne.Text)).ToString();
        }

        private void RomoveGoodFromList(object sender, EventArgs e) 
        {
            Good good = (Good)listOfGoods.SelectedItem;
            goods.Remove(good);
            listOfGoods.Items.Clear();
            listOfGoods.Items.AddRange(goods.ToArray());
            listOfGoods.Update();
        }

        private void EditGoodItem(object sender, EventArgs e) 
        {
            int index = listOfGoods.SelectedIndex;
            Good good = (Good)listOfGoods.SelectedItem;
            good.Name = tb_GoodName.Text;
            good.Description = tb_Desc.Text;
            good.Amount = (int)NUD_Amount.Value;
            good.PricePerOne = decimal.Parse(tb_PricePerOne.Text);
            good.TotalPrice = good.Amount * good.PricePerOne;
            good.Date = dateTimePicker.Value;
            goods[index] = good;
            listOfGoods.Items.Clear();
            listOfGoods.Items.AddRange(goods.ToArray());
            listOfGoods.Update();
        }

        private void SelectedValue(object sender, EventArgs e) 
        {
            Good good = (Good)listOfGoods.SelectedItem;
            //MessageBox.Show(good.ToString());
            tb_GoodName.Text = good.Name;
            tb_Desc.Text = good.Description;
            NUD_Amount.Value = good.Amount;
            tb_PricePerOne.Text = good.PricePerOne.ToString();
            tb_PriceAll.Text = good.TotalPrice.ToString();
            dateTimePicker.Value = good.Date;
        }
        private void DrawCord(PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.White, 2), new Point(200, 100), new Point(200, 600));
            e.Graphics.DrawLine(new Pen(Color.White, 2), new Point(150, 550), new Point(1000, 550));

            e.Graphics.DrawString("Кількість", new Font("Arial", 10), new SolidBrush(Color.White), new Point(125, 75));
            e.Graphics.DrawString("Продукт", new Font("Arial", 10), new SolidBrush(Color.White), new Point(1000, 550));
        }

        private void DrawDiagram(PaintEventArgs e, Point point, Brush brush, int h, List<string> products, int iter, List<int> valuesOfNumberOfGoods)
        {
            int barWidth = 50; // Фиксированная ширина столбца
            e.Graphics.FillRectangle(brush, point.X, point.Y, barWidth, h);

            // Получаем название продукта из объекта Good
            string productName = products[iter];
            e.Graphics.DrawString(productName, new Font("Arial", 10), brush, new PointF(point.X, point.Y + h + 5));
            e.Graphics.DrawString(valuesOfNumberOfGoods[iter].ToString(), new Font("Arial", 10), brush, point.X, point.Y - 25);
        }

        public static List<Color> ColorStructToList()
        {
            return typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
                                .Select(c => (Color)c.GetValue(null, null))
                                .ToList();
        }
        private int GetStep(double listSize, double value) 
        {
            int percent = (int)((value / listSize) * 100);
            int number_from_percent = (int)((450 * percent) / 100);
            int res = 450 - number_from_percent;
            return res;
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            try
            {
                DrawCord(e);
                if (goods.Count == 0)
                {
                    throw new Exception("Пустий список. Неможливо створити аналітику!");
                }

                List<Color> ColorsList = ColorStructToList();
                Random random = new Random(DateTime.Now.Millisecond);

                // Найдем общее количество товаров
                int totalAmount = goods.Sum(good => good.Amount);

                int x = 210;
                int y = 100;
                int h = 450;
                int size = goods.Count;

                for (int i = 0; i < goods.Count; i++)
                {
                    int count = goods[i].Amount;
                    // Масштабируем высоту столбца относительно общего количества товаров
                    int scaledHeight = (int)(h * ((double)count / totalAmount));

                    int step = GetStep(size, count);
                    DrawDiagram(e, new Point(x, y + h - scaledHeight), new SolidBrush(ColorsList[random.Next(ColorsList.Count - 1)]), scaledHeight, goods.Select(x => x.Name).Distinct().ToList(), i, goods.Select(g => g.Amount).ToList());
                    x += 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateAndSaveReceiptToXml(object sender, EventArgs e)
        {
            if (goods.Count == 0)
            {
                MessageBox.Show("Нет товаров для сохранения в чеке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlDocument doc = new XmlDocument();
            // Создаем корневой элемент "Receipt"
            XmlElement root = doc.CreateElement("Receipt");
            doc.AppendChild(root);

            XmlElement storeInfo = doc.CreateElement("StoreInfo");
            storeInfo.InnerText = "Магазин 'Foxtrot 2.0'";
            root.AppendChild(storeInfo);

            XmlElement goodsElement = doc.CreateElement("Goods");
            root.AppendChild(goodsElement);

            foreach (var good in goods)
            {
                // Создаем элемент "Good" для каждого товара
                XmlElement goodElement = doc.CreateElement("Good");
                goodsElement.AppendChild(goodElement);

                CreateXmlElement(doc, goodElement, "Name", good.Name);
                CreateXmlElement(doc, goodElement, "Amount", good.Amount.ToString());
                CreateXmlElement(doc, goodElement, "PricePerOne", good.PricePerOne.ToString("C"));
                CreateXmlElement(doc, goodElement, "TotalPrice", good.TotalPrice.ToString("C"));
            }

            XmlElement totalElement = doc.CreateElement("Total");
            totalElement.InnerText = goods.Sum(g => g.TotalPrice).ToString("C");
            root.AppendChild(totalElement);

            // Сохраняем XML-документ в файл
            string fileName = "receipt.xml";
            doc.Save(fileName);

            DialogResult result = MessageBox.Show($"Чек сохранен в файл: {fileName}. Если хотите увидеть информацию, нажмите 'Да'", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                ShowReceiptInfo();
            }
            else
            {
                return;
            }
        }

        private void CreateXmlElement(XmlDocument doc, XmlElement parent, string elementName, string elementValue)
        {
            XmlElement element = doc.CreateElement(elementName);
            element.InnerText = elementValue;
            parent.AppendChild(element);
        }

        private void ShowReceiptInfo()
        {
            if (goods.Count == 0)
            {
                MessageBox.Show("Нет товаров в чеке для отображения информации.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder receiptInfo = new StringBuilder();
            receiptInfo.AppendLine("Чек:");
            receiptInfo.AppendLine("Магазин 'Foxtrot 2.0'");
            receiptInfo.AppendLine();
            receiptInfo.AppendLine("Товары:");

            foreach (var good in goods)
            {
                receiptInfo.AppendLine($"- Название: {good.Name}");
                receiptInfo.AppendLine($"  Количество: {good.Amount}");
                receiptInfo.AppendLine($"  Цена за единицу: {good.PricePerOne.ToString("C")}");
                receiptInfo.AppendLine($"  Итоговая цена: {good.TotalPrice.ToString("C")}");
                receiptInfo.AppendLine();
            }
            receiptInfo.AppendLine($"Итого: {goods.Sum(g => g.TotalPrice).ToString("C")}");

            MessageBox.Show(receiptInfo.ToString(), "Информация о чеке", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}