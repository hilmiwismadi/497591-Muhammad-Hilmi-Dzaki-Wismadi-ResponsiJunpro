namespace ResponsiJunPro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textNama = new TextBox();
            InputDepart = new ComboBox();
            listBox1 = new ListBox();
            buttonLoadData = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            DGV = new DataGridView();
            buttonLoadTable = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 79);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 118);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 143);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Dept Karyawan";
            // 
            // textNama
            // 
            textNama.Location = new Point(132, 115);
            textNama.Name = "textNama";
            textNama.Size = new Size(250, 23);
            textNama.TabIndex = 3;
            // 
            // InputDepart
            // 
            InputDepart.FormattingEnabled = true;
            InputDepart.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            InputDepart.Location = new Point(132, 144);
            InputDepart.Name = "InputDepart";
            InputDepart.Size = new Size(250, 23);
            InputDepart.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen:", "HR : HR", "ENG : Engineer", "DEV : Developer", "PM : Product M", "FIN : Finance" });
            listBox1.Location = new Point(432, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 139);
            listBox1.TabIndex = 5;
            // 
            // buttonLoadData
            // 
            buttonLoadData.Location = new Point(27, 182);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(160, 23);
            buttonLoadData.TabIndex = 6;
            buttonLoadData.Text = "Insert";
            buttonLoadData.UseVisualStyleBackColor = true;
            buttonLoadData.Click += buttonInsert_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(222, 182);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(160, 23);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(412, 182);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(160, 23);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(27, 216);
            DGV.Name = "DGV";
            DGV.RowTemplate.Height = 25;
            DGV.Size = new Size(545, 150);
            DGV.TabIndex = 9;
            DGV.CellContentClick += DGV_CellContentClick;
            // 
            // buttonLoadTable
            // 
            buttonLoadTable.Location = new Point(578, 216);
            buttonLoadTable.Name = "buttonLoadTable";
            buttonLoadTable.Size = new Size(132, 150);
            buttonLoadTable.TabIndex = 10;
            buttonLoadTable.Text = "Load";
            buttonLoadTable.UseVisualStyleBackColor = true;
            buttonLoadTable.Click += buttonLoadTable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoadTable);
            Controls.Add(DGV);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonLoadData);
            Controls.Add(listBox1);
            Controls.Add(InputDepart);
            Controls.Add(textNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textNama;
        private ComboBox InputDepart;
        private ListBox listBox1;
        private Button buttonLoadData;
        private Button buttonEdit;
        private Button buttonDelete;
        private DataGridView DGV;
        private Button buttonLoadTable;
    }
}