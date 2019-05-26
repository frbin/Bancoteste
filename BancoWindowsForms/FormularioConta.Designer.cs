namespace BancoWindowsForms
{
    partial class FormularioConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbTipodeCliente = new System.Windows.Forms.GroupBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.gbDadosdoCliente = new System.Windows.Forms.GroupBox();
            this.gbTipodeConta = new System.Windows.Forms.GroupBox();
            this.rbContaPoupanca = new System.Windows.Forms.RadioButton();
            this.mtbLimite = new System.Windows.Forms.MaskedTextBox();
            this.rbContaCorrente = new System.Windows.Forms.RadioButton();
            this.lblLimite = new System.Windows.Forms.Label();
            this.cbLimite = new System.Windows.Forms.CheckBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbDatadeNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDatadeNascimento = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemeto = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.cbEndereco = new System.Windows.Forms.ComboBox();
            this.lblTipodeEndereco = new System.Windows.Forms.Label();
            this.txtNomedoCliente = new System.Windows.Forms.TextBox();
            this.lblNomedoCliente = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbTipodeCliente.SuspendLayout();
            this.gbDadosdoCliente.SuspendLayout();
            this.gbTipodeConta.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco Windows";
            // 
            // gbTipodeCliente
            // 
            this.gbTipodeCliente.Controls.Add(this.rbPessoaJuridica);
            this.gbTipodeCliente.Controls.Add(this.rbPessoaFisica);
            this.gbTipodeCliente.Location = new System.Drawing.Point(12, 39);
            this.gbTipodeCliente.Name = "gbTipodeCliente";
            this.gbTipodeCliente.Size = new System.Drawing.Size(225, 60);
            this.gbTipodeCliente.TabIndex = 31;
            this.gbTipodeCliente.TabStop = false;
            this.gbTipodeCliente.Text = "Tipo de Cliente";
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(118, 28);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbPessoaJuridica.TabIndex = 3;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rdPessoaJuridica_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(7, 28);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessoaFisica.TabIndex = 2;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rdPessoaFisica_CheckedChanged);
            // 
            // gbDadosdoCliente
            // 
            this.gbDadosdoCliente.Controls.Add(this.gbTipodeConta);
            this.gbDadosdoCliente.Controls.Add(this.gbGenero);
            this.gbDadosdoCliente.Controls.Add(this.mtbCelular);
            this.gbDadosdoCliente.Controls.Add(this.lblCelular);
            this.gbDadosdoCliente.Controls.Add(this.mtbTelefone);
            this.gbDadosdoCliente.Controls.Add(this.lblTelefone);
            this.gbDadosdoCliente.Controls.Add(this.mtbDatadeNascimento);
            this.gbDadosdoCliente.Controls.Add(this.lblDatadeNascimento);
            this.gbDadosdoCliente.Controls.Add(this.mtbCPF);
            this.gbDadosdoCliente.Controls.Add(this.lblCPF);
            this.gbDadosdoCliente.Controls.Add(this.cbCidade);
            this.gbDadosdoCliente.Controls.Add(this.lblCidade);
            this.gbDadosdoCliente.Controls.Add(this.cbEstado);
            this.gbDadosdoCliente.Controls.Add(this.lblEstado);
            this.gbDadosdoCliente.Controls.Add(this.mtbCEP);
            this.gbDadosdoCliente.Controls.Add(this.lblCEP);
            this.gbDadosdoCliente.Controls.Add(this.txtBairro);
            this.gbDadosdoCliente.Controls.Add(this.lblBairro);
            this.gbDadosdoCliente.Controls.Add(this.txtComplemento);
            this.gbDadosdoCliente.Controls.Add(this.lblComplemeto);
            this.gbDadosdoCliente.Controls.Add(this.txtNumero);
            this.gbDadosdoCliente.Controls.Add(this.lblNumero);
            this.gbDadosdoCliente.Controls.Add(this.txtLogradouro);
            this.gbDadosdoCliente.Controls.Add(this.lblLogradouro);
            this.gbDadosdoCliente.Controls.Add(this.cbEndereco);
            this.gbDadosdoCliente.Controls.Add(this.lblTipodeEndereco);
            this.gbDadosdoCliente.Controls.Add(this.txtNomedoCliente);
            this.gbDadosdoCliente.Controls.Add(this.lblNomedoCliente);
            this.gbDadosdoCliente.Location = new System.Drawing.Point(12, 127);
            this.gbDadosdoCliente.Name = "gbDadosdoCliente";
            this.gbDadosdoCliente.Size = new System.Drawing.Size(908, 297);
            this.gbDadosdoCliente.TabIndex = 32;
            this.gbDadosdoCliente.TabStop = false;
            this.gbDadosdoCliente.Text = "Dados do Cliente";
            // 
            // gbTipodeConta
            // 
            this.gbTipodeConta.Controls.Add(this.rbContaPoupanca);
            this.gbTipodeConta.Controls.Add(this.mtbLimite);
            this.gbTipodeConta.Controls.Add(this.rbContaCorrente);
            this.gbTipodeConta.Controls.Add(this.lblLimite);
            this.gbTipodeConta.Controls.Add(this.cbLimite);
            this.gbTipodeConta.Location = new System.Drawing.Point(490, 196);
            this.gbTipodeConta.Name = "gbTipodeConta";
            this.gbTipodeConta.Size = new System.Drawing.Size(401, 84);
            this.gbTipodeConta.TabIndex = 58;
            this.gbTipodeConta.TabStop = false;
            this.gbTipodeConta.Text = "Tipo de Conta";
            // 
            // rbContaPoupanca
            // 
            this.rbContaPoupanca.AutoSize = true;
            this.rbContaPoupanca.Location = new System.Drawing.Point(12, 50);
            this.rbContaPoupanca.Name = "rbContaPoupanca";
            this.rbContaPoupanca.Size = new System.Drawing.Size(105, 17);
            this.rbContaPoupanca.TabIndex = 36;
            this.rbContaPoupanca.TabStop = true;
            this.rbContaPoupanca.Text = "Conta Poupança";
            this.rbContaPoupanca.UseVisualStyleBackColor = true;
            this.rbContaPoupanca.CheckedChanged += new System.EventHandler(this.rbContaPoupanca_CheckedChanged);
            // 
            // mtbLimite
            // 
            this.mtbLimite.Location = new System.Drawing.Point(285, 20);
            this.mtbLimite.Mask = "$ 0,000.00";
            this.mtbLimite.Name = "mtbLimite";
            this.mtbLimite.Size = new System.Drawing.Size(100, 20);
            this.mtbLimite.TabIndex = 4;
            // 
            // rbContaCorrente
            // 
            this.rbContaCorrente.AutoSize = true;
            this.rbContaCorrente.Location = new System.Drawing.Point(12, 21);
            this.rbContaCorrente.Name = "rbContaCorrente";
            this.rbContaCorrente.Size = new System.Drawing.Size(96, 17);
            this.rbContaCorrente.TabIndex = 35;
            this.rbContaCorrente.TabStop = true;
            this.rbContaCorrente.Text = "Conta Corrente";
            this.rbContaCorrente.UseVisualStyleBackColor = true;
            this.rbContaCorrente.CheckedChanged += new System.EventHandler(this.rbContaCorrente_CheckedChanged);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(245, 23);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(37, 13);
            this.lblLimite.TabIndex = 3;
            this.lblLimite.Text = "Limite:";
            // 
            // cbLimite
            // 
            this.cbLimite.AutoSize = true;
            this.cbLimite.Location = new System.Drawing.Point(130, 23);
            this.cbLimite.Name = "cbLimite";
            this.cbLimite.Size = new System.Drawing.Size(87, 17);
            this.cbLimite.TabIndex = 2;
            this.cbLimite.Text = "Possui Limite";
            this.cbLimite.UseVisualStyleBackColor = true;
            this.cbLimite.CheckedChanged += new System.EventHandler(this.cbLimite_CheckedChanged);
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbFeminino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(490, 138);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(192, 51);
            this.gbGenero.TabIndex = 57;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Gênero";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(101, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 36;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 35;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(607, 110);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(100, 20);
            this.mtbCelular.TabIndex = 56;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(487, 113);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 55;
            this.lblCelular.Text = "Celular:";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(607, 84);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefone.TabIndex = 54;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(487, 87);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 53;
            this.lblTelefone.Text = "Teletone:";
            // 
            // mtbDatadeNascimento
            // 
            this.mtbDatadeNascimento.Location = new System.Drawing.Point(607, 58);
            this.mtbDatadeNascimento.Mask = "00/00/0000";
            this.mtbDatadeNascimento.Name = "mtbDatadeNascimento";
            this.mtbDatadeNascimento.Size = new System.Drawing.Size(100, 20);
            this.mtbDatadeNascimento.TabIndex = 52;
            this.mtbDatadeNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDatadeNascimento
            // 
            this.lblDatadeNascimento.AutoSize = true;
            this.lblDatadeNascimento.Location = new System.Drawing.Point(487, 61);
            this.lblDatadeNascimento.Name = "lblDatadeNascimento";
            this.lblDatadeNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDatadeNascimento.TabIndex = 51;
            this.lblDatadeNascimento.Text = "Data de Nascimento:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(607, 32);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 20);
            this.mtbCPF.TabIndex = 50;
            this.mtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCPF_MaskInputRejected);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(487, 35);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 49;
            this.lblCPF.Text = "CPF:";
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(100, 249);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(140, 21);
            this.cbCidade.TabIndex = 48;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(4, 253);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 47;
            this.lblCidade.Text = "Cidade:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(100, 222);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(58, 21);
            this.cbEstado.TabIndex = 46;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(4, 228);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 45;
            this.lblEstado.Text = "Estado:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(100, 196);
            this.mtbCEP.Mask = "00000-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(100, 20);
            this.mtbCEP.TabIndex = 44;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(4, 201);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 43;
            this.lblCEP.Text = "CEP:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(100, 169);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(140, 20);
            this.txtBairro.TabIndex = 42;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(4, 173);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 41;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(100, 143);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(140, 20);
            this.txtComplemento.TabIndex = 40;
            // 
            // lblComplemeto
            // 
            this.lblComplemeto.AutoSize = true;
            this.lblComplemeto.Location = new System.Drawing.Point(4, 147);
            this.lblComplemeto.Name = "lblComplemeto";
            this.lblComplemeto.Size = new System.Drawing.Size(74, 13);
            this.lblComplemeto.TabIndex = 39;
            this.lblComplemeto.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(100, 118);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(77, 20);
            this.txtNumero.TabIndex = 38;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(4, 122);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 37;
            this.lblNumero.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(100, 89);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(328, 20);
            this.txtLogradouro.TabIndex = 36;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(4, 92);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 35;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // cbEndereco
            // 
            this.cbEndereco.FormattingEnabled = true;
            this.cbEndereco.Items.AddRange(new object[] {
            "Rua",
            "Avenida",
            "Alameda"});
            this.cbEndereco.Location = new System.Drawing.Point(100, 60);
            this.cbEndereco.Name = "cbEndereco";
            this.cbEndereco.Size = new System.Drawing.Size(140, 21);
            this.cbEndereco.TabIndex = 34;
            // 
            // lblTipodeEndereco
            // 
            this.lblTipodeEndereco.AutoSize = true;
            this.lblTipodeEndereco.Location = new System.Drawing.Point(3, 64);
            this.lblTipodeEndereco.Name = "lblTipodeEndereco";
            this.lblTipodeEndereco.Size = new System.Drawing.Size(95, 13);
            this.lblTipodeEndereco.TabIndex = 33;
            this.lblTipodeEndereco.Text = "Tipo do Endereço:";
            // 
            // txtNomedoCliente
            // 
            this.txtNomedoCliente.Location = new System.Drawing.Point(100, 28);
            this.txtNomedoCliente.Name = "txtNomedoCliente";
            this.txtNomedoCliente.Size = new System.Drawing.Size(328, 20);
            this.txtNomedoCliente.TabIndex = 32;
            // 
            // lblNomedoCliente
            // 
            this.lblNomedoCliente.AutoSize = true;
            this.lblNomedoCliente.Location = new System.Drawing.Point(4, 31);
            this.lblNomedoCliente.Name = "lblNomedoCliente";
            this.lblNomedoCliente.Size = new System.Drawing.Size(88, 13);
            this.lblNomedoCliente.TabIndex = 31;
            this.lblNomedoCliente.Text = "Nome do Cliente:";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimparCampos.Location = new System.Drawing.Point(726, 465);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(113, 23);
            this.btnLimparCampos.TabIndex = 33;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(845, 465);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormularioConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(952, 494);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.gbDadosdoCliente);
            this.Controls.Add(this.gbTipodeCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormularioConta";
            this.Text = "Formulário de Conta";
            this.Load += new System.EventHandler(this.FormularioConta_Load);
            this.gbTipodeCliente.ResumeLayout(false);
            this.gbTipodeCliente.PerformLayout();
            this.gbDadosdoCliente.ResumeLayout(false);
            this.gbDadosdoCliente.PerformLayout();
            this.gbTipodeConta.ResumeLayout(false);
            this.gbTipodeConta.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTipodeCliente;
        private System.Windows.Forms.GroupBox gbDadosdoCliente;
        private System.Windows.Forms.GroupBox gbTipodeConta;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbDatadeNascimento;
        private System.Windows.Forms.Label lblDatadeNascimento;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemeto;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.ComboBox cbEndereco;
        private System.Windows.Forms.Label lblTipodeEndereco;
        private System.Windows.Forms.TextBox txtNomedoCliente;
        private System.Windows.Forms.Label lblNomedoCliente;
        private System.Windows.Forms.MaskedTextBox mtbLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.CheckBox cbLimite;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.RadioButton rbContaPoupanca;
        private System.Windows.Forms.RadioButton rbContaCorrente;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
    }
}

