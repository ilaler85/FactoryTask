using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.DateAccess;
using WindowsFormsApp8.Forms;

namespace WindowsFormsApp8.Forms
{
    public partial class Add : Form
    {
        public Factory factory { get; private set; }
        private readonly List<Address> addresses;
        private readonly List<Owner> owners;
        private readonly FactoryDataAccess factoryDataAccess;

        public Add(List<Address> addresses, List<Owner> owners, FactoryDataAccess factoryDataAccess)
        {
            InitializeComponent();
            this.Text = "Добавить завод";
            factory = new Factory();
            this.addresses = addresses;
            this.owners = owners;
            this.factoryDataAccess = factoryDataAccess;
            FillOwner();
            FillAddress();
        }

        public Add(Factory Factory, List<Address> addresses, List<Owner> owners,
               FactoryDataAccess factoryDataAccess): this(addresses, owners, factoryDataAccess)
        {
            this.Text = "Редактировать";
            factory = Factory;
            FillFactory();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            factory.Name = NameBox.Text;
            factory.Square = int.Parse(SquareBox.Text);
            if (check.Checked)
                factory.opening_year = int.Parse(OpeningJearBox.Text);
            else
                factory.opening_year = null;
            factory.owner = OwnerComboBox.SelectedItem as Owner;
            factory.address = AddressComboBox.SelectedItem as Address;
            DialogResult = DialogResult.OK;
        }



        private void FillOwner()
        {
            OwnerComboBox.ValueMember = "id_owner";
            OwnerComboBox.DisplayMember = "FIO";
            OwnerComboBox.DataSource = owners;
        }

        private void FillAddress()
        {
            AddressComboBox.ValueMember = "id_street";
            AddressComboBox.DisplayMember = "SCC";
            AddressComboBox.DataSource = addresses;
        }

        private void FillFactory()
        {
            NameBox.Text = factory.Name;
            SquareBox.Text = factory.Square.ToString();
            OpeningJearBox.Text = factory.opening_year.ToString();
            OwnerComboBox.SelectedItem = owners.Where(t => t.id_owner == factory.owner.id_owner).First();
            AddressComboBox.SelectedItem = addresses.Where(t => t.id_street == factory.address.id_street).First();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if(check.Checked)
            {
                OpeningJearBox.Visible = true;
            }
            else
            {
                OpeningJearBox.Visible = false;
            }
        }
    }
}
