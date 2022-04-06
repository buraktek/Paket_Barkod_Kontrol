
namespace Paket_Barkod_Kontrol
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
            this.textBox_barkod = new System.Windows.Forms.TextBox();
            this.listView_kontrol_edilen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_box_state = new System.Windows.Forms.Label();
            this.listView_kontrol_edilmeyen = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_kontrol_edilen = new System.Windows.Forms.Label();
            this.label_kontrol_edilmeyen = new System.Windows.Forms.Label();
            this.label_koli_no = new System.Windows.Forms.Label();
            this.label_model_no = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_bilgi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_box = new System.Windows.Forms.PictureBox();
            this.pictureBox_box_state = new System.Windows.Forms.PictureBox();
            this.label_koli_no_value = new System.Windows.Forms.Label();
            this.label_model_no_value = new System.Windows.Forms.Label();
            this.timer_label_action = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_info = new System.Windows.Forms.PictureBox();
            this.button_Kayitlari_Listele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_box_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_barkod
            // 
            this.textBox_barkod.BackColor = System.Drawing.Color.Ivory;
            this.textBox_barkod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_barkod.Location = new System.Drawing.Point(105, 11);
            this.textBox_barkod.Name = "textBox_barkod";
            this.textBox_barkod.Size = new System.Drawing.Size(349, 26);
            this.textBox_barkod.TabIndex = 2;
            this.textBox_barkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_barkod.Click += new System.EventHandler(this.textBox_barkod_Click);
            this.textBox_barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_barkod_KeyPress);
            // 
            // listView_kontrol_edilen
            // 
            this.listView_kontrol_edilen.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_kontrol_edilen.BackColor = System.Drawing.Color.Honeydew;
            this.listView_kontrol_edilen.CausesValidation = false;
            this.listView_kontrol_edilen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listView_kontrol_edilen.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_kontrol_edilen.FullRowSelect = true;
            this.listView_kontrol_edilen.GridLines = true;
            this.listView_kontrol_edilen.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_kontrol_edilen.HideSelection = false;
            this.listView_kontrol_edilen.HoverSelection = true;
            this.listView_kontrol_edilen.Location = new System.Drawing.Point(294, 251);
            this.listView_kontrol_edilen.Name = "listView_kontrol_edilen";
            this.listView_kontrol_edilen.Scrollable = false;
            this.listView_kontrol_edilen.Size = new System.Drawing.Size(230, 446);
            this.listView_kontrol_edilen.TabIndex = 1;
            this.listView_kontrol_edilen.UseCompatibleStateImageBehavior = false;
            this.listView_kontrol_edilen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "#";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Seri No";
            this.columnHeader5.Width = 190;
            // 
            // label_box_state
            // 
            this.label_box_state.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_box_state.BackColor = System.Drawing.Color.Transparent;
            this.label_box_state.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_box_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_box_state.Location = new System.Drawing.Point(12, 355);
            this.label_box_state.Name = "label_box_state";
            this.label_box_state.Size = new System.Drawing.Size(254, 75);
            this.label_box_state.TabIndex = 8;
            this.label_box_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView_kontrol_edilmeyen
            // 
            this.listView_kontrol_edilmeyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(205)))), ((int)(((byte)(194)))));
            this.listView_kontrol_edilmeyen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listView_kontrol_edilmeyen.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_kontrol_edilmeyen.GridLines = true;
            this.listView_kontrol_edilmeyen.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_kontrol_edilmeyen.HideSelection = false;
            this.listView_kontrol_edilmeyen.HoverSelection = true;
            this.listView_kontrol_edilmeyen.Location = new System.Drawing.Point(27, 251);
            this.listView_kontrol_edilmeyen.Name = "listView_kontrol_edilmeyen";
            this.listView_kontrol_edilmeyen.Scrollable = false;
            this.listView_kontrol_edilmeyen.Size = new System.Drawing.Size(230, 446);
            this.listView_kontrol_edilmeyen.TabIndex = 12;
            this.listView_kontrol_edilmeyen.UseCompatibleStateImageBehavior = false;
            this.listView_kontrol_edilmeyen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "#";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Seri No";
            this.columnHeader6.Width = 200;
            // 
            // label_kontrol_edilen
            // 
            this.label_kontrol_edilen.BackColor = System.Drawing.Color.Transparent;
            this.label_kontrol_edilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kontrol_edilen.Location = new System.Drawing.Point(294, 228);
            this.label_kontrol_edilen.Name = "label_kontrol_edilen";
            this.label_kontrol_edilen.Size = new System.Drawing.Size(230, 23);
            this.label_kontrol_edilen.TabIndex = 16;
            this.label_kontrol_edilen.Text = "Kontrol Edilen: ";
            this.label_kontrol_edilen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_kontrol_edilmeyen
            // 
            this.label_kontrol_edilmeyen.BackColor = System.Drawing.Color.Transparent;
            this.label_kontrol_edilmeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kontrol_edilmeyen.Location = new System.Drawing.Point(24, 228);
            this.label_kontrol_edilmeyen.Name = "label_kontrol_edilmeyen";
            this.label_kontrol_edilmeyen.Size = new System.Drawing.Size(232, 23);
            this.label_kontrol_edilmeyen.TabIndex = 17;
            this.label_kontrol_edilmeyen.Text = "Kontrol Edilmeyen: ";
            this.label_kontrol_edilmeyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_koli_no
            // 
            this.label_koli_no.BackColor = System.Drawing.Color.Transparent;
            this.label_koli_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_koli_no.Location = new System.Drawing.Point(4, 59);
            this.label_koli_no.Name = "label_koli_no";
            this.label_koli_no.Size = new System.Drawing.Size(79, 23);
            this.label_koli_no.TabIndex = 18;
            this.label_koli_no.Text = "Koli No: ";
            // 
            // label_model_no
            // 
            this.label_model_no.BackColor = System.Drawing.Color.Transparent;
            this.label_model_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_model_no.Location = new System.Drawing.Point(219, 59);
            this.label_model_no.Name = "label_model_no";
            this.label_model_no.Size = new System.Drawing.Size(95, 23);
            this.label_model_no.TabIndex = 19;
            this.label_model_no.Text = "Model No:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Paket Durumu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Barkod:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_bilgi
            // 
            this.label_bilgi.BackColor = System.Drawing.Color.Transparent;
            this.label_bilgi.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgi.Location = new System.Drawing.Point(28, 95);
            this.label_bilgi.Name = "label_bilgi";
            this.label_bilgi.Size = new System.Drawing.Size(374, 125);
            this.label_bilgi.TabIndex = 23;
            this.label_bilgi.Text = "-";
            this.label_bilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox_box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_box_state);
            this.panel1.Controls.Add(this.pictureBox_box_state);
            this.panel1.Location = new System.Drawing.Point(554, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 436);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox_box
            // 
            this.pictureBox_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_box.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_box.Location = new System.Drawing.Point(9, 32);
            this.pictureBox_box.Name = "pictureBox_box";
            this.pictureBox_box.Size = new System.Drawing.Size(254, 212);
            this.pictureBox_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_box.TabIndex = 11;
            this.pictureBox_box.TabStop = false;
            // 
            // pictureBox_box_state
            // 
            this.pictureBox_box_state.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_box_state.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_box_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_box_state.Location = new System.Drawing.Point(68, 245);
            this.pictureBox_box_state.Name = "pictureBox_box_state";
            this.pictureBox_box_state.Size = new System.Drawing.Size(128, 107);
            this.pictureBox_box_state.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_box_state.TabIndex = 4;
            this.pictureBox_box_state.TabStop = false;
            // 
            // label_koli_no_value
            // 
            this.label_koli_no_value.BackColor = System.Drawing.Color.Transparent;
            this.label_koli_no_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_koli_no_value.ForeColor = System.Drawing.Color.DarkCyan;
            this.label_koli_no_value.Location = new System.Drawing.Point(74, 59);
            this.label_koli_no_value.Name = "label_koli_no_value";
            this.label_koli_no_value.Size = new System.Drawing.Size(139, 23);
            this.label_koli_no_value.TabIndex = 25;
            this.label_koli_no_value.Text = "-";
            // 
            // label_model_no_value
            // 
            this.label_model_no_value.BackColor = System.Drawing.Color.Transparent;
            this.label_model_no_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_model_no_value.ForeColor = System.Drawing.Color.DarkCyan;
            this.label_model_no_value.Location = new System.Drawing.Point(308, 59);
            this.label_model_no_value.Name = "label_model_no_value";
            this.label_model_no_value.Size = new System.Drawing.Size(234, 23);
            this.label_model_no_value.TabIndex = 26;
            this.label_model_no_value.Text = "-";
            // 
            // timer_label_action
            // 
            this.timer_label_action.Interval = 300;
            this.timer_label_action.Tick += new System.EventHandler(this.timer_label_action_Tick);
            // 
            // pictureBox_info
            // 
            this.pictureBox_info.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_info.Location = new System.Drawing.Point(419, 100);
            this.pictureBox_info.Name = "pictureBox_info";
            this.pictureBox_info.Size = new System.Drawing.Size(123, 103);
            this.pictureBox_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_info.TabIndex = 15;
            this.pictureBox_info.TabStop = false;
            // 
            // button_Kayitlari_Listele
            // 
            this.button_Kayitlari_Listele.BackColor = System.Drawing.Color.MintCream;
            this.button_Kayitlari_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Kayitlari_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kayitlari_Listele.Image = global::Paket_Barkod_Kontrol.Properties.Resources.Open_Folder_icon__1_;
            this.button_Kayitlari_Listele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kayitlari_Listele.Location = new System.Drawing.Point(560, 504);
            this.button_Kayitlari_Listele.Name = "button_Kayitlari_Listele";
            this.button_Kayitlari_Listele.Padding = new System.Windows.Forms.Padding(50, 0, 15, 0);
            this.button_Kayitlari_Listele.Size = new System.Drawing.Size(263, 52);
            this.button_Kayitlari_Listele.TabIndex = 9;
            this.button_Kayitlari_Listele.Text = "Kayıtları Listele";
            this.button_Kayitlari_Listele.UseVisualStyleBackColor = false;
            this.button_Kayitlari_Listele.Click += new System.EventHandler(this.button_Kayitlari_Listele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Paket_Barkod_Kontrol.Properties.Resources.Barcode_Scanner_Model_AS9500_F07_watermarked_2k;
            this.pictureBox1.Location = new System.Drawing.Point(460, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_barkod);
            this.panel2.Location = new System.Drawing.Point(9, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 53);
            this.panel2.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paket_Barkod_Kontrol.Properties.Resources._ebd2a732;
            this.ClientSize = new System.Drawing.Size(832, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_model_no_value);
            this.Controls.Add(this.label_koli_no_value);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_bilgi);
            this.Controls.Add(this.label_model_no);
            this.Controls.Add(this.label_koli_no);
            this.Controls.Add(this.label_kontrol_edilmeyen);
            this.Controls.Add(this.label_kontrol_edilen);
            this.Controls.Add(this.pictureBox_info);
            this.Controls.Add(this.listView_kontrol_edilmeyen);
            this.Controls.Add(this.button_Kayitlari_Listele);
            this.Controls.Add(this.listView_kontrol_edilen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paket Seri No Kontrol Yazılımı v1.0";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_box_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_barkod;
        private System.Windows.Forms.ListView listView_kontrol_edilen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox_box_state;
        private System.Windows.Forms.Label label_box_state;
        private System.Windows.Forms.Button button_Kayitlari_Listele;
        private System.Windows.Forms.ListView listView_kontrol_edilmeyen;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox_info;
        private System.Windows.Forms.Label label_kontrol_edilen;
        private System.Windows.Forms.Label label_kontrol_edilmeyen;
        private System.Windows.Forms.Label label_koli_no;
        private System.Windows.Forms.Label label_model_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_bilgi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label_koli_no_value;
        private System.Windows.Forms.Label label_model_no_value;
        private System.Windows.Forms.Timer timer_label_action;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

