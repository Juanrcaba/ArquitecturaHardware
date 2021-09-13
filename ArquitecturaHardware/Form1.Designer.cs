
namespace ArquitecturaHardware
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.lbl_conexion = new System.Windows.Forms.Label();
            this.pb_conexion = new System.Windows.Forms.ProgressBar();
            this.cmb_baudrate = new System.Windows.Forms.ComboBox();
            this.cmb_COM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbox_light_1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbox_light_4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbox_light_3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbox_light_2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_light_1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_light_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_light_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_light_2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto COM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_desconectar);
            this.groupBox1.Controls.Add(this.btn_conectar);
            this.groupBox1.Controls.Add(this.lbl_conexion);
            this.groupBox1.Controls.Add(this.pb_conexion);
            this.groupBox1.Controls.Add(this.cmb_baudrate);
            this.groupBox1.Controls.Add(this.cmb_COM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión";
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(134, 137);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(100, 29);
            this.btn_desconectar.TabIndex = 7;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(9, 137);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(100, 29);
            this.btn_conectar.TabIndex = 6;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // lbl_conexion
            // 
            this.lbl_conexion.AutoSize = true;
            this.lbl_conexion.Location = new System.Drawing.Point(74, 112);
            this.lbl_conexion.Name = "lbl_conexion";
            this.lbl_conexion.Size = new System.Drawing.Size(102, 13);
            this.lbl_conexion.TabIndex = 5;
            this.lbl_conexion.Text = "DESCONNECTED!!";
            // 
            // pb_conexion
            // 
            this.pb_conexion.Location = new System.Drawing.Point(9, 87);
            this.pb_conexion.Name = "pb_conexion";
            this.pb_conexion.Size = new System.Drawing.Size(225, 23);
            this.pb_conexion.TabIndex = 4;
            // 
            // cmb_baudrate
            // 
            this.cmb_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_baudrate.FormattingEnabled = true;
            this.cmb_baudrate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.cmb_baudrate.Location = new System.Drawing.Point(78, 54);
            this.cmb_baudrate.Name = "cmb_baudrate";
            this.cmb_baudrate.Size = new System.Drawing.Size(156, 21);
            this.cmb_baudrate.TabIndex = 3;
            // 
            // cmb_COM
            // 
            this.cmb_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_COM.FormattingEnabled = true;
            this.cmb_COM.Location = new System.Drawing.Point(78, 26);
            this.cmb_COM.Name = "cmb_COM";
            this.cmb_COM.Size = new System.Drawing.Size(156, 21);
            this.cmb_COM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // pbox_light_1
            // 
            this.pbox_light_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_light_1.Image = global::ArquitecturaHardware.Properties.Resources.switch_off;
            this.pbox_light_1.Location = new System.Drawing.Point(42, 38);
            this.pbox_light_1.Name = "pbox_light_1";
            this.pbox_light_1.Size = new System.Drawing.Size(122, 128);
            this.pbox_light_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_light_1.TabIndex = 2;
            this.pbox_light_1.TabStop = false;
            this.pbox_light_1.Click += new System.EventHandler(this.pbox_light_1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pbox_light_4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pbox_light_3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pbox_light_2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbox_light_1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(258, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Luces";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Luz 4";
            // 
            // pbox_light_4
            // 
            this.pbox_light_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_light_4.Image = global::ArquitecturaHardware.Properties.Resources.switch_off;
            this.pbox_light_4.Location = new System.Drawing.Point(426, 38);
            this.pbox_light_4.Name = "pbox_light_4";
            this.pbox_light_4.Size = new System.Drawing.Size(122, 128);
            this.pbox_light_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_light_4.TabIndex = 13;
            this.pbox_light_4.TabStop = false;
            this.pbox_light_4.Click += new System.EventHandler(this.pbox_light_4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Luz 3";
            // 
            // pbox_light_3
            // 
            this.pbox_light_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_light_3.Image = global::ArquitecturaHardware.Properties.Resources.switch_off;
            this.pbox_light_3.Location = new System.Drawing.Point(298, 38);
            this.pbox_light_3.Name = "pbox_light_3";
            this.pbox_light_3.Size = new System.Drawing.Size(122, 128);
            this.pbox_light_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_light_3.TabIndex = 11;
            this.pbox_light_3.TabStop = false;
            this.pbox_light_3.Click += new System.EventHandler(this.pbox_light_3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Luz 2";
            // 
            // pbox_light_2
            // 
            this.pbox_light_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_light_2.Image = global::ArquitecturaHardware.Properties.Resources.switch_off;
            this.pbox_light_2.Location = new System.Drawing.Point(170, 38);
            this.pbox_light_2.Name = "pbox_light_2";
            this.pbox_light_2.Size = new System.Drawing.Size(122, 128);
            this.pbox_light_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_light_2.TabIndex = 9;
            this.pbox_light_2.TabStop = false;
            this.pbox_light_2.Click += new System.EventHandler(this.pbox_light_2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Luz 1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 208);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Luces";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_light_1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_light_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_light_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_light_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Label lbl_conexion;
        private System.Windows.Forms.ProgressBar pb_conexion;
        private System.Windows.Forms.ComboBox cmb_baudrate;
        private System.Windows.Forms.ComboBox cmb_COM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbox_light_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbox_light_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbox_light_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbox_light_2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

