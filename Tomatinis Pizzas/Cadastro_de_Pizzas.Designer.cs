
namespace Tomatinis_Pizzas
{
    partial class Cadastro_de_Pizzas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSabor = new System.Windows.Forms.Label();
            this.Composicao = new System.Windows.Forms.Label();
            this.lblTipoPizza = new System.Windows.Forms.Label();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.txtComposicao = new System.Windows.Forms.TextBox();
            this.grpTemBorda = new System.Windows.Forms.GroupBox();
            this.rdNao = new System.Windows.Forms.RadioButton();
            this.rdSim = new System.Windows.Forms.RadioButton();
            this.grpTipoBorda = new System.Windows.Forms.GroupBox();
            this.chkVulcao = new System.Windows.Forms.CheckBox();
            this.chkMista = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkCheddar = new System.Windows.Forms.CheckBox();
            this.cmbTipoPizza = new System.Windows.Forms.ComboBox();
            this.grpTamanhoPizza = new System.Windows.Forms.GroupBox();
            this.chkFamilia = new System.Windows.Forms.CheckBox();
            this.chkPequena = new System.Windows.Forms.CheckBox();
            this.lblValorPizzaPequena = new System.Windows.Forms.Label();
            this.txtValorPizzaFamilia = new System.Windows.Forms.TextBox();
            this.lblValorPizzaFamilia = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorPizzaPequena = new System.Windows.Forms.TextBox();
            this.grpTemBorda.SuspendLayout();
            this.grpTipoBorda.SuspendLayout();
            this.grpTamanhoPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(11, 49);
            this.lblSabor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(54, 22);
            this.lblSabor.TabIndex = 0;
            this.lblSabor.Text = "Sabor:";
            // 
            // Composicao
            // 
            this.Composicao.AutoSize = true;
            this.Composicao.Location = new System.Drawing.Point(11, 82);
            this.Composicao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Composicao.Name = "Composicao";
            this.Composicao.Size = new System.Drawing.Size(93, 22);
            this.Composicao.TabIndex = 1;
            this.Composicao.Text = "Composição";
            // 
            // lblTipoPizza
            // 
            this.lblTipoPizza.AutoSize = true;
            this.lblTipoPizza.Location = new System.Drawing.Point(11, 9);
            this.lblTipoPizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPizza.Name = "lblTipoPizza";
            this.lblTipoPizza.Size = new System.Drawing.Size(103, 22);
            this.lblTipoPizza.TabIndex = 2;
            this.lblTipoPizza.Text = "Tipo da Pizza";
            // 
            // txtSabor
            // 
            this.txtSabor.Location = new System.Drawing.Point(65, 43);
            this.txtSabor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(275, 29);
            this.txtSabor.TabIndex = 3;
            // 
            // txtComposicao
            // 
            this.txtComposicao.Location = new System.Drawing.Point(15, 108);
            this.txtComposicao.Margin = new System.Windows.Forms.Padding(2);
            this.txtComposicao.Multiline = true;
            this.txtComposicao.Name = "txtComposicao";
            this.txtComposicao.Size = new System.Drawing.Size(324, 62);
            this.txtComposicao.TabIndex = 4;
            // 
            // grpTemBorda
            // 
            this.grpTemBorda.Controls.Add(this.rdNao);
            this.grpTemBorda.Controls.Add(this.rdSim);
            this.grpTemBorda.Location = new System.Drawing.Point(15, 174);
            this.grpTemBorda.Margin = new System.Windows.Forms.Padding(2);
            this.grpTemBorda.Name = "grpTemBorda";
            this.grpTemBorda.Padding = new System.Windows.Forms.Padding(2);
            this.grpTemBorda.Size = new System.Drawing.Size(324, 64);
            this.grpTemBorda.TabIndex = 5;
            this.grpTemBorda.TabStop = false;
            this.grpTemBorda.Text = "A Pizza permite adicionar Borda?";
            // 
            // rdNao
            // 
            this.rdNao.AutoSize = true;
            this.rdNao.Checked = true;
            this.rdNao.Location = new System.Drawing.Point(74, 28);
            this.rdNao.Margin = new System.Windows.Forms.Padding(2);
            this.rdNao.Name = "rdNao";
            this.rdNao.Size = new System.Drawing.Size(57, 26);
            this.rdNao.TabIndex = 1;
            this.rdNao.TabStop = true;
            this.rdNao.Text = "Não";
            this.rdNao.UseVisualStyleBackColor = true;
            this.rdNao.CheckedChanged += new System.EventHandler(this.rdNao_CheckedChanged);
            // 
            // rdSim
            // 
            this.rdSim.AutoSize = true;
            this.rdSim.Location = new System.Drawing.Point(4, 28);
            this.rdSim.Margin = new System.Windows.Forms.Padding(2);
            this.rdSim.Name = "rdSim";
            this.rdSim.Size = new System.Drawing.Size(55, 26);
            this.rdSim.TabIndex = 0;
            this.rdSim.Text = "Sim";
            this.rdSim.UseVisualStyleBackColor = true;
            this.rdSim.CheckedChanged += new System.EventHandler(this.rdSim_CheckedChanged);
            // 
            // grpTipoBorda
            // 
            this.grpTipoBorda.Controls.Add(this.chkVulcao);
            this.grpTipoBorda.Controls.Add(this.chkMista);
            this.grpTipoBorda.Controls.Add(this.chkCatupiry);
            this.grpTipoBorda.Controls.Add(this.chkCheddar);
            this.grpTipoBorda.Enabled = false;
            this.grpTipoBorda.Location = new System.Drawing.Point(15, 242);
            this.grpTipoBorda.Margin = new System.Windows.Forms.Padding(2);
            this.grpTipoBorda.Name = "grpTipoBorda";
            this.grpTipoBorda.Padding = new System.Windows.Forms.Padding(2);
            this.grpTipoBorda.Size = new System.Drawing.Size(324, 160);
            this.grpTipoBorda.TabIndex = 6;
            this.grpTipoBorda.TabStop = false;
            this.grpTipoBorda.Text = "Tipo de Borda que a Pizza aceita";
            // 
            // chkVulcao
            // 
            this.chkVulcao.AutoSize = true;
            this.chkVulcao.Location = new System.Drawing.Point(7, 121);
            this.chkVulcao.Margin = new System.Windows.Forms.Padding(2);
            this.chkVulcao.Name = "chkVulcao";
            this.chkVulcao.Size = new System.Drawing.Size(223, 26);
            this.chkVulcao.TabIndex = 3;
            this.chkVulcao.Text = "borda vulcão de doce de leite";
            this.chkVulcao.UseVisualStyleBackColor = true;
            // 
            // chkMista
            // 
            this.chkMista.AutoSize = true;
            this.chkMista.Location = new System.Drawing.Point(7, 89);
            this.chkMista.Margin = new System.Windows.Forms.Padding(2);
            this.chkMista.Name = "chkMista";
            this.chkMista.Size = new System.Drawing.Size(242, 26);
            this.chkMista.TabIndex = 2;
            this.chkMista.Text = "borda mista (catupiry/cheddar)";
            this.chkMista.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(7, 59);
            this.chkCatupiry.Margin = new System.Windows.Forms.Padding(2);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(206, 26);
            this.chkCatupiry.TabIndex = 1;
            this.chkCatupiry.Text = "borda de catupiry original";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkCheddar
            // 
            this.chkCheddar.AutoSize = true;
            this.chkCheddar.Location = new System.Drawing.Point(7, 28);
            this.chkCheddar.Margin = new System.Windows.Forms.Padding(2);
            this.chkCheddar.Name = "chkCheddar";
            this.chkCheddar.Size = new System.Drawing.Size(148, 26);
            this.chkCheddar.TabIndex = 0;
            this.chkCheddar.Text = "borda de cheddar";
            this.chkCheddar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoPizza
            // 
            this.cmbTipoPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPizza.FormattingEnabled = true;
            this.cmbTipoPizza.Items.AddRange(new object[] {
            "Salgada",
            "Doce"});
            this.cmbTipoPizza.Location = new System.Drawing.Point(118, 6);
            this.cmbTipoPizza.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPizza.Name = "cmbTipoPizza";
            this.cmbTipoPizza.Size = new System.Drawing.Size(142, 30);
            this.cmbTipoPizza.TabIndex = 7;
            // 
            // grpTamanhoPizza
            // 
            this.grpTamanhoPizza.Controls.Add(this.chkFamilia);
            this.grpTamanhoPizza.Controls.Add(this.chkPequena);
            this.grpTamanhoPizza.Location = new System.Drawing.Point(15, 408);
            this.grpTamanhoPizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTamanhoPizza.Name = "grpTamanhoPizza";
            this.grpTamanhoPizza.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTamanhoPizza.Size = new System.Drawing.Size(324, 59);
            this.grpTamanhoPizza.TabIndex = 8;
            this.grpTamanhoPizza.TabStop = false;
            this.grpTamanhoPizza.Text = "O tamanho das Pizzas";
            // 
            // chkFamilia
            // 
            this.chkFamilia.AutoSize = true;
            this.chkFamilia.Location = new System.Drawing.Point(114, 28);
            this.chkFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFamilia.Name = "chkFamilia";
            this.chkFamilia.Size = new System.Drawing.Size(80, 26);
            this.chkFamilia.TabIndex = 1;
            this.chkFamilia.Text = "Família";
            this.chkFamilia.UseVisualStyleBackColor = true;
            this.chkFamilia.CheckedChanged += new System.EventHandler(this.chkFamilia_CheckedChanged);
            // 
            // chkPequena
            // 
            this.chkPequena.AutoSize = true;
            this.chkPequena.Location = new System.Drawing.Point(6, 28);
            this.chkPequena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPequena.Name = "chkPequena";
            this.chkPequena.Size = new System.Drawing.Size(87, 26);
            this.chkPequena.TabIndex = 0;
            this.chkPequena.Text = "Pequena";
            this.chkPequena.UseVisualStyleBackColor = true;
            this.chkPequena.CheckedChanged += new System.EventHandler(this.chkPequena_CheckedChanged);
            // 
            // lblValorPizzaPequena
            // 
            this.lblValorPizzaPequena.AutoSize = true;
            this.lblValorPizzaPequena.Enabled = false;
            this.lblValorPizzaPequena.Location = new System.Drawing.Point(12, 478);
            this.lblValorPizzaPequena.Name = "lblValorPizzaPequena";
            this.lblValorPizzaPequena.Size = new System.Drawing.Size(175, 22);
            this.lblValorPizzaPequena.TabIndex = 10;
            this.lblValorPizzaPequena.Text = "Valor da Pizza Pequena:";
            // 
            // txtValorPizzaFamilia
            // 
            this.txtValorPizzaFamilia.Enabled = false;
            this.txtValorPizzaFamilia.Location = new System.Drawing.Point(193, 512);
            this.txtValorPizzaFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorPizzaFamilia.Name = "txtValorPizzaFamilia";
            this.txtValorPizzaFamilia.Size = new System.Drawing.Size(67, 29);
            this.txtValorPizzaFamilia.TabIndex = 12;
            this.txtValorPizzaFamilia.Text = " S";
            // 
            // lblValorPizzaFamilia
            // 
            this.lblValorPizzaFamilia.AutoSize = true;
            this.lblValorPizzaFamilia.Enabled = false;
            this.lblValorPizzaFamilia.Location = new System.Drawing.Point(12, 515);
            this.lblValorPizzaFamilia.Name = "lblValorPizzaFamilia";
            this.lblValorPizzaFamilia.Size = new System.Drawing.Size(168, 22);
            this.lblValorPizzaFamilia.TabIndex = 13;
            this.lblValorPizzaFamilia.Text = "Valor da Pizza Família:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(131, 550);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 37);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorPizzaPequena
            // 
            this.txtValorPizzaPequena.Enabled = false;
            this.txtValorPizzaPequena.Location = new System.Drawing.Point(193, 475);
            this.txtValorPizzaPequena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorPizzaPequena.Name = "txtValorPizzaPequena";
            this.txtValorPizzaPequena.Size = new System.Drawing.Size(67, 29);
            this.txtValorPizzaPequena.TabIndex = 15;
            // 
            // Cadastro_de_Pizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 589);
            this.Controls.Add(this.txtValorPizzaPequena);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblValorPizzaFamilia);
            this.Controls.Add(this.txtValorPizzaFamilia);
            this.Controls.Add(this.lblValorPizzaPequena);
            this.Controls.Add(this.grpTamanhoPizza);
            this.Controls.Add(this.cmbTipoPizza);
            this.Controls.Add(this.grpTipoBorda);
            this.Controls.Add(this.grpTemBorda);
            this.Controls.Add(this.txtComposicao);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.lblTipoPizza);
            this.Controls.Add(this.Composicao);
            this.Controls.Add(this.lblSabor);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Cadastro_de_Pizzas";
            this.Text = "Cadastro de Pizzas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTemBorda.ResumeLayout(false);
            this.grpTemBorda.PerformLayout();
            this.grpTipoBorda.ResumeLayout(false);
            this.grpTipoBorda.PerformLayout();
            this.grpTamanhoPizza.ResumeLayout(false);
            this.grpTamanhoPizza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label Composicao;
        private System.Windows.Forms.Label lblTipoPizza;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.TextBox txtComposicao;
        private System.Windows.Forms.GroupBox grpTemBorda;
        private System.Windows.Forms.RadioButton rdNao;
        private System.Windows.Forms.RadioButton rdSim;
        private System.Windows.Forms.GroupBox grpTipoBorda;
        private System.Windows.Forms.CheckBox chkVulcao;
        private System.Windows.Forms.CheckBox chkMista;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkCheddar;
        private System.Windows.Forms.ComboBox cmbTipoPizza;
        private System.Windows.Forms.GroupBox grpTamanhoPizza;
        private System.Windows.Forms.CheckBox chkFamilia;
        private System.Windows.Forms.CheckBox chkPequena;
        private System.Windows.Forms.Label lblValorPizzaPequena;
        private System.Windows.Forms.TextBox txtValorPizzaFamilia;
        private System.Windows.Forms.Label lblValorPizzaFamilia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorPizzaPequena;
    }
}

