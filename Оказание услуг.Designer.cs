
namespace ИС_Салон_красоты
{
    partial class Form2
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
            this.услугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.практика1DataSet = new ИС_Салон_красоты.практика1DataSet();
            this.оказаниеУслугBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.оказаниеУслугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оказание_услугTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.Оказание_услугTableAdapter();
            this.услугаTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.УслугаTableAdapter();
            this.услугаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.записьВСалонBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запись_в_салонTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.Запись_в_салонTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDОказаниеУслугDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяИДатаЗаписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЗаписьВСалонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оказаниеУслугBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDОборудованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оборудованиеTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.ОборудованиеTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDМастерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мастерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастерTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.МастерTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.практика1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаниеУслугBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаниеУслугBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записьВСалонBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаниеУслугBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // услугаBindingSource
            // 
            this.услугаBindingSource.DataMember = "Услуга";
            this.услугаBindingSource.DataSource = this.практика1DataSet;
            // 
            // практика1DataSet
            // 
            this.практика1DataSet.DataSetName = "практика1DataSet";
            this.практика1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оказаниеУслугBindingSource1
            // 
            this.оказаниеУслугBindingSource1.DataMember = "Оказание услуг";
            this.оказаниеУслугBindingSource1.DataSource = this.практика1DataSet;
            // 
            // оказаниеУслугBindingSource
            // 
            this.оказаниеУслугBindingSource.DataMember = "Оказание услуг";
            this.оказаниеУслугBindingSource.DataSource = this.практика1DataSet;
            // 
            // оказание_услугTableAdapter
            // 
            this.оказание_услугTableAdapter.ClearBeforeFill = true;
            // 
            // услугаTableAdapter
            // 
            this.услугаTableAdapter.ClearBeforeFill = true;
            // 
            // услугаBindingSource1
            // 
            this.услугаBindingSource1.DataMember = "Услуга";
            this.услугаBindingSource1.DataSource = this.практика1DataSet;
            // 
            // записьВСалонBindingSource
            // 
            this.записьВСалонBindingSource.DataMember = "Запись в салон";
            this.записьВСалонBindingSource.DataSource = this.практика1DataSet;
            // 
            // запись_в_салонTableAdapter
            // 
            this.запись_в_салонTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDОказаниеУслугDataGridViewTextBoxColumn,
            this.услугаDataGridViewTextBoxColumn,
            this.времяИДатаЗаписиDataGridViewTextBoxColumn,
            this.iDЗаписьВСалонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.оказаниеУслугBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(43, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 230);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDОказаниеУслугDataGridViewTextBoxColumn
            // 
            this.iDОказаниеУслугDataGridViewTextBoxColumn.DataPropertyName = "ID_Оказание услуг";
            this.iDОказаниеУслугDataGridViewTextBoxColumn.HeaderText = "ID_Оказание услуг";
            this.iDОказаниеУслугDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОказаниеУслугDataGridViewTextBoxColumn.Name = "iDОказаниеУслугDataGridViewTextBoxColumn";
            this.iDОказаниеУслугDataGridViewTextBoxColumn.Width = 125;
            // 
            // услугаDataGridViewTextBoxColumn
            // 
            this.услугаDataGridViewTextBoxColumn.DataPropertyName = "Услуга";
            this.услугаDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.услугаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.услугаDataGridViewTextBoxColumn.Name = "услугаDataGridViewTextBoxColumn";
            this.услугаDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяИДатаЗаписиDataGridViewTextBoxColumn
            // 
            this.времяИДатаЗаписиDataGridViewTextBoxColumn.DataPropertyName = "Время и дата записи";
            this.времяИДатаЗаписиDataGridViewTextBoxColumn.HeaderText = "Время и дата записи";
            this.времяИДатаЗаписиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяИДатаЗаписиDataGridViewTextBoxColumn.Name = "времяИДатаЗаписиDataGridViewTextBoxColumn";
            this.времяИДатаЗаписиDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDЗаписьВСалонDataGridViewTextBoxColumn
            // 
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.DataPropertyName = "ID_Запись в салон";
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.HeaderText = "ID_Запись в салон";
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.Name = "iDЗаписьВСалонDataGridViewTextBoxColumn";
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.Width = 125;
            // 
            // оказаниеУслугBindingSource2
            // 
            this.оказаниеУслугBindingSource2.DataMember = "Оказание услуг";
            this.оказаниеУслугBindingSource2.DataSource = this.практика1DataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1130, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 57);
            this.button3.TabIndex = 7;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDОборудованиеDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.оборудованиеBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(795, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(491, 230);
            this.dataGridView2.TabIndex = 8;
            // 
            // iDОборудованиеDataGridViewTextBoxColumn
            // 
            this.iDОборудованиеDataGridViewTextBoxColumn.DataPropertyName = "ID_Оборудование";
            this.iDОборудованиеDataGridViewTextBoxColumn.HeaderText = "ID_Оборудование";
            this.iDОборудованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОборудованиеDataGridViewTextBoxColumn.Name = "iDОборудованиеDataGridViewTextBoxColumn";
            this.iDОборудованиеDataGridViewTextBoxColumn.Width = 150;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.Width = 150;
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.практика1DataSet;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМастерDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.возрастDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.мастерBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(43, 392);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1243, 169);
            this.dataGridView3.TabIndex = 9;
            // 
            // iDМастерDataGridViewTextBoxColumn
            // 
            this.iDМастерDataGridViewTextBoxColumn.DataPropertyName = "ID_Мастер";
            this.iDМастерDataGridViewTextBoxColumn.HeaderText = "ID_Мастер";
            this.iDМастерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDМастерDataGridViewTextBoxColumn.Name = "iDМастерDataGridViewTextBoxColumn";
            this.iDМастерDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            this.возрастDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.Width = 125;
            // 
            // мастерBindingSource
            // 
            this.мастерBindingSource.DataMember = "Мастер";
            this.мастерBindingSource.DataSource = this.практика1DataSet;
            // 
            // мастерTableAdapter
            // 
            this.мастерTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(679, 567);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 57);
            this.button4.TabIndex = 10;
            this.button4.Text = "Следующий лист";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 57);
            this.button5.TabIndex = 11;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(522, 567);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 57);
            this.button6.TabIndex = 12;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(795, 281);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 57);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(358, 567);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 57);
            this.button7.TabIndex = 14;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(282, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Оказание услуг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(999, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Оборудование";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(570, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Мастер";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Оказание_услуг";
            this.Load += new System.EventHandler(this.Оказание_услуг_Load);
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.практика1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаниеУслугBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаниеУслугBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записьВСалонBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оказаниеУслугBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public практика1DataSet практика1DataSet;
        private System.Windows.Forms.BindingSource оказаниеУслугBindingSource;
        public практика1DataSetTableAdapters.Оказание_услугTableAdapter оказание_услугTableAdapter;
        private System.Windows.Forms.BindingSource услугаBindingSource;
        public практика1DataSetTableAdapters.УслугаTableAdapter услугаTableAdapter;
        private System.Windows.Forms.BindingSource оказаниеУслугBindingSource1;
        private System.Windows.Forms.BindingSource услугаBindingSource1;
        private System.Windows.Forms.BindingSource записьВСалонBindingSource;
        public практика1DataSetTableAdapters.Запись_в_салонTableAdapter запись_в_салонTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDОказаниеУслугDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn услугаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn времяИДатаЗаписиDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDЗаписьВСалонDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource оказаниеУслугBindingSource2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        public практика1DataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource мастерBindingSource;
        public практика1DataSetTableAdapters.МастерTableAdapter мастерTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМастерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОборудованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}