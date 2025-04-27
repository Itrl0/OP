using OP.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OP
{
    public partial class fridgeOpen : Form
    {
        private ProductRepository _repository;
        private Dictionary<string, TextBox> _productTextBoxMap;
        public fridgeOpen()
        {
            InitializeComponent();

            var storage = new JsonStorage<Product>("products.json");
            _repository = new ProductRepository(storage);

            _productTextBoxMap = new Dictionary<string, TextBox>(StringComparer.OrdinalIgnoreCase)
            {
                { "Ковбаса", quantitytextBox37 },
                { "Сир", textBox36 },
                { "Капуста", textBox35 },
                { "Перець", textBox34 },
                { "Бекон", textBox33 },
                { "Вода", textBox32 },
                { "Зелень", textBox31 },
                { "Яйце", textBox38 },
                { "Масло", textBox43 },
                { "Хліб", textBox46 },
                { "Булочки", textBox45 },
                { "Помідор", textBox50 },
                { "Огірок", textBox51 },
                { "Салат", textBox52 },
                { "Авокадо", textBox59 },
                { "Фарш", textBox39 },
                { "М'ясо", textBox42 },
                { "Печериці", textBox47 },
                { "Молоко", textBox44 },
                { "Риба", textBox56 },
                { "Морква", textBox54 },
                { "Домашній сир", textBox55 },
                { "Морозиво", textBox60 },
                { "Вишня", textBox40 },
                { "Картопля", textBox41 },
                { "Лаваш", textBox48 },
                { "Цибуля", textBox49 },
                { "Буряк", textBox53 },
                { "Соус", textBox58 },
                { "Майонез", textBox57 },
                { "Томатна паста", textBox61 }
            };

            
            LoadProductQuantities();
        }
        private void LoadProductQuantities()
        {
            var products = _repository.GetAll();

            foreach (var product in products)
            {
                if (_productTextBoxMap.TryGetValue(product.Name, out var textBox))
                {
                    textBox.Text = product.Quantity.ToString();
                }
            }
        }

        private void IncrementProductQuantity(string productName, TextBox quantitytextbox)
        {
            var products = _repository.GetAll();
            var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                
                product.Quantity += 1;
                _repository.Update(product);
            }
            else
            {
               
                var newProduct = new Product(productName, 1);
                _repository.Add(newProduct);
                product = newProduct;
            }
            quantitytextbox.Text = product.Quantity.ToString();
        }

        private void ReduceProductQuantity(string productName, TextBox quantitytextbox)
        {
            var products = _repository.GetAll();
            var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                
                product.Quantity -= 1;
                _repository.Update(product);
            }
            else
            {
                
                var newProduct = new Product(productName, 1);
                _repository.Add(newProduct);
                product = newProduct;
            }
            quantitytextbox.Text = product.Quantity.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            kitchen kitchenForm = new kitchen();
            kitchenForm.Show();
            this.Hide();
        }

        private void back_MouseDown(object sender, MouseEventArgs e)
        {
            back.BackColor = Color.Red;
        }

        private void back_MouseUp(object sender, MouseEventArgs e)
        {
            back.BackColor = SystemColors.Control;
        }
        Point lastpoint;
        private void fridgeOpen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void fridgeOpen_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastpoint = new Point(e.X, e.Y);
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Ковбаса", quantitytextBox37);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Сир", textBox36);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Капуста", textBox35);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Перець", textBox34);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Бекон", textBox33);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Вода", textBox32);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Зелень", textBox31);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Яйце", textBox38);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Масло", textBox43);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Хліб", textBox46);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Булочки", textBox45);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Помідор", textBox50);
        }

        private void button102_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Огірок", textBox51);
        }

        private void button104_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Салат", textBox52);
        }

        private void button118_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Авокадо", textBox59);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Фарш", textBox39);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("М'ясо", textBox42);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Печериці", textBox47);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Молоко", textBox44);
        }

        private void button112_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Риба", textBox56);
        }

        private void button108_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Морква", textBox54);
        }

        private void button110_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Домашній сир", textBox55);
        }

        private void button120_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Морозиво", textBox60);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Вишня", textBox40);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Картопля", textBox41);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Лаваш", textBox48);
        }

        private void button98_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Цибуля", textBox49);
        }

        private void button106_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Буряк", textBox53);
        }

        private void button116_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Соус", textBox58);
        }

        private void button114_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Майонез", textBox57);
        }

        private void button122_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Томатна паста", textBox61);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Перець", textBox34);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Reduce_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Ковбаса", quantitytextBox37);
        }

        private void Reduce1_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Сир", textBox36);
        }

        private void Reduce2_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Капуста", textBox35);
        }

        private void Reduce4_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Бекон", textBox33);
        }

        private void Reduce5_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Вода", textBox32);
        }

        private void Reduce6_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Зелень", textBox31);
        }

        private void Reduce7_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Яйце", textBox38);
        }

        private void Reduce8_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Масло", textBox43);
        }

        private void Reduce9_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Хліб", textBox46);
        }

        private void Reduce10_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Булочки", textBox45);
        }

        private void Reduce11_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Помідор", textBox50);
        }

        private void Reduce12_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Огірок", textBox51);
        }

        private void Reduce13_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Салат", textBox52);
        }

        private void Reduce14_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Авокадо", textBox59);
        }

        private void Reduce15_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Фарш", textBox39);
        }

        private void Reduce16_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("М'ясо", textBox42);
        }

        private void Reduce17_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Печериці", textBox47);
        }

        private void Reduce18_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Молоко", textBox44);
        }

        private void Reduce19_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Риба", textBox56);
        }

        private void Reduce20_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Морква", textBox54);
        }

        private void Reduce21_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Домашній сир", textBox55);
        }

        private void Reduce22_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Морозиво", textBox60);
        }

        private void Reduce23_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Вишня", textBox40);
        }

        private void Reduce24_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Картопля", textBox41);
        }

        private void Reduce25_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Лаваш", textBox48);
        }

        private void Reduce26_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Цибуля", textBox49);
        }

        private void Reduce27_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Буряк", textBox53);
        }

        private void Reduce28_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Соус", textBox58);
        }

        private void Reduce29_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Майонез", textBox57);
        }

        private void Reduce30_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Томатна паста", textBox61);
        }
    }
}
