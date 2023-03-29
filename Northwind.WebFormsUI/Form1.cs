using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productService.GetAll();
        }

        private void LoadCategories()
        {
            //Select Category
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            //Create
            cbxCreateProductCategory.DataSource = _categoryService.GetAll();
            cbxCreateProductCategory.DisplayMember = "CategoryName";
            cbxCreateProductCategory.ValueMember = "CategoryId";

            //Update
            cbxUpdateProductCategory.DataSource = _categoryService.GetAll();
            cbxUpdateProductCategory.DisplayMember = "CategoryName";
            cbxUpdateProductCategory.ValueMember = "CategoryId";
        }


        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                dgvProducts.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbxSearch.Text != "")
            {
                dgvProducts.DataSource = _productService.GetProductByProductName(tbxSearch.Text);
            }
            else if(cbxCategory.SelectedValue != null)
            {
                dgvProducts.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(
                new Product()
                {
                    ProductName = tbxCreateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxCreateProductCategory.SelectedValue),
                    UnitPrice = Convert.ToInt32(tbxCreateProductUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxCreateProductStock.Text),
                    QuantityPerUnit = tbxCreateQuantityPerUnit.Text,
                });
                LoadProducts();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hatalı",MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product()
                {
                    ProductId = Convert.ToInt32(tbxUpdateProductID.Text),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxUpdateProductCategory.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxUpdateProductPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUpdateProductStock.Text),
                    QuantityPerUnit = tbxUpdateQuantityPerUnit.Text
                });
                LoadProducts();
                gbxUpdateProduct.Visible = false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hatalı ürün girişi", MessageBoxButtons.OK);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           if(dgvProducts.CurrentRow != null)
            {
                try
                {
                    MessageBox.Show(dgvProducts.CurrentRow.Cells[0].Value.ToString());
                    _productService.Delete(
                    new Product
                    {
                        ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value)
                    });
                    LoadProducts();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateProductID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateProductName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateProductCategory.SelectedValue = dgvProducts.CurrentRow.Cells[2].Value;
            tbxUpdateProductPrice.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateProductStock.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            gbxUpdateProduct.Visible = true;
        }
    }
}
