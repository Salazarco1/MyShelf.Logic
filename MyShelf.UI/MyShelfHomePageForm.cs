using MyShelf.Logic.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShelf.UI
{
    public partial class MyShelfHomePageForm : Form
    {
        public MSClient Client { get; set; }
        public MyShelfHomePageForm(MSClient client)
        {
            InitializeComponent();
            Client = client;
        }
    }
}
