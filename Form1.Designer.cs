
namespace ИС_Салон_красоты
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDЗаписьВСалонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Клиент = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.практика1DataSet = new ИС_Салон_красоты.практика1DataSet();
            this.Мастер = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.мастерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Услуга = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.услугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.записьВСалонBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запись_в_салонTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.Запись_в_салонTableAdapter();
            this.tbStr = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.услугаTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.УслугаTableAdapter();
            this.мастерTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.МастерTableAdapter();
            this.клиентTableAdapter = new ИС_Салон_красоты.практика1DataSetTableAdapters.КлиентTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDКлиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDМастерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мастерBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.услугаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.практика1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записьВСалонBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаписьВСалонDataGridViewTextBoxColumn,
            this.датаЗаписиDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.Клиент,
            this.Мастер,
            this.Услуга});
            this.dataGridView1.DataSource = this.записьВСалонBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDЗаписьВСалонDataGridViewTextBoxColumn
            // 
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.DataPropertyName = "ID_Запись в салон";
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.HeaderText = "ID_Запись в салон";
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.Name = "iDЗаписьВСалонDataGridViewTextBoxColumn";
            this.iDЗаписьВСалонDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаЗаписиDataGridViewTextBoxColumn
            // 
            this.датаЗаписиDataGridViewTextBoxColumn.DataPropertyName = "Дата записи";
            this.датаЗаписиDataGridViewTextBoxColumn.HeaderText = "Дата записи";
            this.датаЗаписиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗаписиDataGridViewTextBoxColumn.Name = "датаЗаписиDataGridViewTextBoxColumn";
            this.датаЗаписиDataGridViewTextBoxColumn.Width = 150;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.Width = 150;
            // 
            // Клиент
            // 
            this.Клиент.DataPropertyName = "ID_Клиент";
            this.Клиент.DataSource = this.клиентBindingSource;
            this.Клиент.DisplayMember = "Фамилия";
            this.Клиент.HeaderText = "Клиент";
            this.Клиент.MinimumWidth = 6;
            this.Клиент.Name = "Клиент";
            this.Клиент.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Клиент.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Клиент.ValueMember = "ID_Клиент";
            this.Клиент.Width = 125;
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
            // Мастер
            // 
            this.Мастер.DataPropertyName = "ID_Мастер";
            this.Мастер.DataSource = this.мастерBindingSource;
            this.Мастер.DisplayMember = "Фамилия";
            this.Мастер.HeaderText = "Мастер";
            this.Мастер.MinimumWidth = 6;
            this.Мастер.Name = "Мастер";
            this.Мастер.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Мастер.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Мастер.ValueMember = "ID_Мастер";
            this.Мастер.Width = 125;
            // 
            // мастерBindingSource
            // 
            this.мастерBindingSource.DataMember = "Мастер";
            this.мастерBindingSource.DataSource = this.практика1DataSet;
            // 
            // Услуга
            // 
            this.Услуга.DataPropertyName = "ID_Услуга";
            this.Услуга.DataSource = this.услугаBindingSource;
            this.Услуга.DisplayMember = "Наименование";
            this.Услуга.HeaderText = "Услуга";
            this.Услуга.MinimumWidth = 6;
            this.Услуга.Name = "Услуга";
            this.Услуга.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Услуга.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Услуга.ValueMember = "ID_Услуга";
            this.Услуга.Width = 125;
            // 
            // услугаBindingSource
            // 
            this.услугаBindingSource.DataMember = "Услуга";
            this.услугаBindingSource.DataSource = this.практика1DataSet;
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
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(49, 741);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(120, 50);
            this.tbStr.TabIndex = 3;
            this.tbStr.Text = "Найти";
            this.tbStr.UseVisualStyleBackColor = true;
            this.tbStr.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1066, 741);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // услугаTableAdapter
            // 
            this.услугаTableAdapter.ClearBeforeFill = true;
            // 
            // мастерTableAdapter
            // 
            this.мастерTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 741);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.клиентBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1211, 191);
            this.dataGridView2.TabIndex = 6;
            // 
            // iDКлиентDataGridViewTextBoxColumn
            // 
            this.iDКлиентDataGridViewTextBoxColumn.DataPropertyName = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.HeaderText = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDКлиентDataGridViewTextBoxColumn.Name = "iDКлиентDataGridViewTextBoxColumn";
            this.iDКлиентDataGridViewTextBoxColumn.Width = 125;
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
            // клиентBindingSource1
            // 
            this.клиентBindingSource1.DataMember = "Клиент";
            this.клиентBindingSource1.DataSource = this.практика1DataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМастерDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.возрастDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn1,
            this.полDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.мастерBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(12, 525);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1222, 187);
            this.dataGridView3.TabIndex = 7;
            // 
            // iDМастерDataGridViewTextBoxColumn
            // 
            this.iDМастерDataGridViewTextBoxColumn.DataPropertyName = "ID_Мастер";
            this.iDМастерDataGridViewTextBoxColumn.HeaderText = "ID_Мастер";
            this.iDМастерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDМастерDataGridViewTextBoxColumn.Name = "iDМастерDataGridViewTextBoxColumn";
            this.iDМастерDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            this.фамилияDataGridViewTextBoxColumn1.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            this.имяDataGridViewTextBoxColumn1.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            this.отчествоDataGridViewTextBoxColumn1.Width = 125;
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            this.возрастDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn1
            // 
            this.телефонDataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn1.Name = "телефонDataGridViewTextBoxColumn1";
            this.телефонDataGridViewTextBoxColumn1.Width = 125;
            // 
            // полDataGridViewTextBoxColumn1
            // 
            this.полDataGridViewTextBoxColumn1.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn1.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.полDataGridViewTextBoxColumn1.Name = "полDataGridViewTextBoxColumn1";
            this.полDataGridViewTextBoxColumn1.Width = 125;
            // 
            // мастерBindingSource1
            // 
            this.мастерBindingSource1.DataMember = "Мастер";
            this.мастерBindingSource1.DataSource = this.практика1DataSet;
            // 
            // услугаBindingSource1
            // 
            this.услугаBindingSource1.DataMember = "Услуга";
            this.услугаBindingSource1.DataSource = this.практика1DataSet;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(504, 740);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 51);
            this.button5.TabIndex = 9;
            this.button5.Text = "Следующий лист";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(357, 741);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 50);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Запись в салон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(473, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(493, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Мастер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 863);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Запись в салон";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.практика1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записьВСалонBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public практика1DataSet практика1DataSet;
        public System.Windows.Forms.BindingSource записьВСалонBindingSource;
        public практика1DataSetTableAdapters.Запись_в_салонTableAdapter запись_в_салонTableAdapter;
        public System.Windows.Forms.Button tbStr;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.BindingSource услугаBindingSource;
        public практика1DataSetTableAdapters.УслугаTableAdapter услугаTableAdapter;
        public System.Windows.Forms.BindingSource мастерBindingSource;
        public практика1DataSetTableAdapters.МастерTableAdapter мастерTableAdapter;
        public System.Windows.Forms.BindingSource клиентBindingSource;
        public практика1DataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаписьВСалонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаписиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Клиент;
        private System.Windows.Forms.DataGridViewComboBoxColumn Мастер;
        private System.Windows.Forms.DataGridViewComboBoxColumn Услуга;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource клиентBindingSource1;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМастерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn1;
        public System.Windows.Forms.BindingSource мастерBindingSource1;
        public System.Windows.Forms.BindingSource услугаBindingSource1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}