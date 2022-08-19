using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octur2022
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Validar();
           
        }

        private bool Validar()
        {
            if (txtNome.Text == "" || txtSenha.Text == "" || txtUsuario.Text == "") {
                MessageBox.Show("eRROR aPIPA");
                return true;
            } else {
                MessageBox.Show("Foda");
                return false;
            }
        }

       
    
            
            }
        

       

        
            

        }
    
    

