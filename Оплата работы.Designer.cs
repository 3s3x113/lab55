
namespace ИС_Салон_красоты
{
    partial class Оплата_работы
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDОплатаРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаЗатраченныхМатериаловDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаработымастераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доходСУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.практика1DataSet = new ИС_Салон_красоты.практика1DataSet();
            this.iDМастерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.мастерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оплатаРаботыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оказаниеУслугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оплата_работыTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.Оплата_работыTableAdapter();
            this.клиентTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.КлиентTableAdapter();
            this.мастерTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.МастерTableAdapter();
            this.оказание_услугTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.Оказание_услугTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDУслугаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОборудованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугаTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.УслугаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.практика1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаРаботыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаниеУслугBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDОплатаРаботыDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.суммаЗатраченныхМатериаловDataGridViewTextBoxColumn,
            this.суммаработымастераDataGridViewTextBoxColumn,
            this.доходСУслугиDataGridViewTextBoxColumn,
            this.iDКлиентDataGridViewTextBoxColumn,
            this.iDМастерDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.оплатаРаботыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDОплатаРаботыDataGridViewTextBoxColumn
            // 
            this.iDОплатаРаботыDataGridViewTextBoxColumn.DataPropertyName = "ID_Оплата работы";
            this.iDОплатаРаботыDataGridViewTextBoxColumn.HeaderText = "ID_Оплата работы";
            this.iDОплатаРаботыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОплатаРаботыDataGridViewTextBoxColumn.Name = "iDОплатаРаботыDataGridViewTextBoxColumn";
            this.iDОплатаРаботыDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммаЗатраченныхМатериаловDataGridViewTextBoxColumn
            // 
            this.суммаЗатраченныхМатериаловDataGridViewTextBoxColumn.DataPropertyName = "Сумма затраченных материалов";
            this.суммаЗатраченныхМатериаловDataGridViewTextBoxColumn.HeaderText = "Сумма затраченных материалов";
            this.суммаЗатраченныхМатериаловDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаЗатраченныхМатериаловDataGridViewTextBoxColumn.Name = "суммаЗатраченныхМатериаловDataGridViewTextBoxColumn";
            this.суммаЗатраченныхМатериаловDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммаработымастераDataGridViewTextBoxColumn
            // 
            this.суммаработымастераDataGridViewTextBoxColumn.DataPropertyName = "Сумма_работы_мастера";
            this.суммаработымастераDataGridViewTextBoxColumn.HeaderText = "Сумма работы мастера";
            this.суммаработымастераDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаработымастераDataGridViewTextBoxColumn.Name = "суммаработымастераDataGridViewTextBoxColumn";
            this.суммаработымастераDataGridViewTextBoxColumn.Width = 180;
            // 
            // доходСУслугиDataGridViewTextBoxColumn
            // 
            this.доходСУслугиDataGridViewTextBoxColumn.DataPropertyName = "Доход с услуги";
            this.доходСУслугиDataGridViewTextBoxColumn.HeaderText = "Доход с услуги";
            this.доходСУслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.доходСУслугиDataGridViewTextBoxColumn.Name = "доходСУслугиDataGridViewTextBoxColumn";
            this.доходСУслугиDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDКлиентDataGridViewTextBoxColumn
            // 
            this.iDКлиентDataGridViewTextBoxColumn.DataPropertyName = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.DataSource = this.клиентBindingSource;
            this.iDКлиентDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.iDКлиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDКлиентDataGridViewTextBoxColumn.Name = "iDКлиентDataGridViewTextBoxColumn";
            this.iDКлиентDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDКлиентDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDКлиентDataGridViewTextBoxColumn.ValueMember = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.Width = 125;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.практика1DataSet;
            // 
            // практика1DataSet
            // 
            this.практика1DataSet.DataSetName = "практика1DataSet";
            this.практика1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDМастерDataGridViewTextBoxColumn
            // 
            this.iDМастерDataGridViewTextBoxColumn.DataPropertyName = "ID_Мастер";
            this.iDМастерDataGridViewTextBoxColumn.DataSource = this.мастерBindingSource;
            this.iDМастерDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.iDМастерDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.iDМастерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDМастерDataGridViewTextBoxColumn.Name = "iDМастерDataGridViewTextBoxColumn";
            this.iDМастерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDМастерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDМастерDataGridViewTextBoxColumn.ValueMember = "ID_Мастер";
            this.iDМастерDataGridViewTextBoxColumn.Width = 125;
            // 
            // мастерBindingSource
            // 
            this.мастерBindingSource.DataMember = "Мастер";
            this.мастерBindingSource.DataSource = this.практика1DataSet;
            // 
            // оплатаРаботыBindingSource
            // 
            this.оплатаРаботыBindingSource.DataMember = "Оплата работы";
            this.оплатаРаботыBindingSource.DataSource = this.практика1DataSet;
            // 
            // оказаниеУслугBindingSource
            // 
            this.оказаниеУслугBindingSource.DataMember = "Оказание услуг";
            this.оказаниеУслугBindingSource.DataSource = this.практика1DataSet;
            // 
            // оплата_работыTableAdapter
            // 
            this.оплата_работыTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // мастерTableAdapter
            // 
            this.мастерTableAdapter.ClearBeforeFill = true;
            // 
            // оказание_услугTableAdapter
            // 
            this.оказание_услугTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDУслугаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.iDОборудованиеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.услугаBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(37, 377);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1166, 135);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDУслугаDataGridViewTextBoxColumn
            // 
            this.iDУслугаDataGridViewTextBoxColumn.DataPropertyName = "ID_Услуга";
            this.iDУслугаDataGridViewTextBoxColumn.HeaderText = "ID_Услуга";
            this.iDУслугаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDУслугаDataGridViewTextBoxColumn.Name = "iDУслугаDataGridViewTextBoxColumn";
            this.iDУслугаDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDОборудованиеDataGridViewTextBoxColumn
            // 
            this.iDОборудованиеDataGridViewTextBoxColumn.DataPropertyName = "ID_Оборудование";
            this.iDОборудованиеDataGridViewTextBoxColumn.HeaderText = "ID_Оборудование";
            this.iDОборудованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОборудованиеDataGridViewTextBoxColumn.Name = "iDОборудованиеDataGridViewTextBoxColumn";
            this.iDОборудованиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // услугаBindingSource
            // 
            this.услугаBindingSource.DataMember = "Услуга";
            this.услугаBindingSource.DataSource = this.практика1DataSet;
            // 
            // услугаTableAdapter
            // 
            this.услугаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1017, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(37, 263);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 48);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(486, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оплата работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(527, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Услуга";
            // 
            // Оплата_работы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Оплата_работы";
            this.Text = "Оплата_работы";
            this.Load += new System.EventHandler(this.Оплата_работы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.практика1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаРаботыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаниеУслугBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public практика1DataSet практика1DataSet;
        public System.Windows.Forms.BindingSource оплатаРаботыBindingSource;
        public практика1DataSetTableAdapters.Оплата_работыTableAdapter оплата_работыTableAdapter;
        public System.Windows.Forms.BindingSource клиентBindingSource;
        public практика1DataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        public System.Windows.Forms.BindingSource мастерBindingSource;
        public практика1DataSetTableAdapters.МастерTableAdapter мастерTableAdapter;
        public System.Windows.Forms.BindingSource оказаниеУслугBindingSource;
        public практика1DataSetTableAdapters.Оказание_услугTableAdapter оказание_услугTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDОплатаРаботыDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn суммаЗатраченныхМатериаловDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn суммаработымастераDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn доходСУслугиDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDОказаниеУслугDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDКлиентDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDМастерDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource услугаBindingSource;
        public практика1DataSetTableAdapters.УслугаTableAdapter услугаTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDУслугаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDОборудованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}