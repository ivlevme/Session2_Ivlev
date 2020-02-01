namespace Session1_Ivlev
{
    partial class managerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.schedulesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.session2_IvlevDataSet = new Session1_Ivlev.Session2_IvlevDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.schedulesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.schedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.schedulesTableAdapter = new Session1_Ivlev.Session2_IvlevDataSetTableAdapters.SchedulesTableAdapter();
            this.airportsTableAdapter = new Session1_Ivlev.Session2_IvlevDataSetTableAdapters.AirportsTableAdapter();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routesTableAdapter = new Session1_Ivlev.Session2_IvlevDataSetTableAdapters.RoutesTableAdapter();
            this.fKScheduleRoutesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKRoutesAirports31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routes1TableAdapter = new Session1_Ivlev.Session2_IvlevDataSetTableAdapters.Routes1TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_IvlevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKScheduleRoutesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoutesAirports31BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered by";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.schedulesBindingSource1;
            this.comboBox5.DisplayMember = "FlightNumber";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(337, 87);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 9;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // schedulesBindingSource1
            // 
            this.schedulesBindingSource1.DataMember = "Schedules";
            this.schedulesBindingSource1.DataSource = this.session2_IvlevDataSet;
            // 
            // session2_IvlevDataSet
            // 
            this.session2_IvlevDataSet.DataSetName = "Session2_IvlevDataSet";
            this.session2_IvlevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Flight Number";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.schedulesBindingSource2;
            this.comboBox4.DisplayMember = "Time";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(79, 87);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // schedulesBindingSource2
            // 
            this.schedulesBindingSource2.DataMember = "Schedules";
            this.schedulesBindingSource2.DataSource = this.session2_IvlevDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "outbound";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(613, 36);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sort by";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.airportsBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(337, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "Airports";
            this.airportsBindingSource.DataSource = this.session2_IvlevDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.airportsBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // airportsBindingSource1
            // 
            this.airportsBindingSource1.DataMember = "Airports";
            this.airportsBindingSource1.DataSource = this.session2_IvlevDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // schedulesBindingSource
            // 
            this.schedulesBindingSource.DataMember = "Schedules";
            this.schedulesBindingSource.DataSource = this.session2_IvlevDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel Flight";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Edit flight";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(682, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Import changes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.From,
            this.To,
            this.flightNumberDataGridViewTextBoxColumn,
            this.aircraftIDDataGridViewTextBoxColumn,
            this.routeIDDataGridViewTextBoxColumn,
            this.economyPriceDataGridViewTextBoxColumn,
            this.confirmedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.schedulesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 277);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // From
            // 
            this.From.DataSource = this.airportsBindingSource;
            this.From.DisplayMember = "Name";
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 6;
            this.From.Name = "From";
            this.From.ReadOnly = true;
            this.From.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.From.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.From.ValueMember = "Name";
            this.From.Width = 125;
            // 
            // To
            // 
            this.To.DataSource = this.airportsBindingSource;
            this.To.DisplayMember = "Name";
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 6;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.To.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.To.Width = 125;
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.DataPropertyName = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            this.flightNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // aircraftIDDataGridViewTextBoxColumn
            // 
            this.aircraftIDDataGridViewTextBoxColumn.DataPropertyName = "AircraftID";
            this.aircraftIDDataGridViewTextBoxColumn.HeaderText = "AircraftID";
            this.aircraftIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aircraftIDDataGridViewTextBoxColumn.Name = "aircraftIDDataGridViewTextBoxColumn";
            this.aircraftIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            this.routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
            this.routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
            this.routeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            this.routeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // economyPriceDataGridViewTextBoxColumn
            // 
            this.economyPriceDataGridViewTextBoxColumn.DataPropertyName = "EconomyPrice";
            this.economyPriceDataGridViewTextBoxColumn.HeaderText = "EconomyPrice";
            this.economyPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.economyPriceDataGridViewTextBoxColumn.Name = "economyPriceDataGridViewTextBoxColumn";
            this.economyPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // confirmedDataGridViewCheckBoxColumn
            // 
            this.confirmedDataGridViewCheckBoxColumn.DataPropertyName = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.HeaderText = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.confirmedDataGridViewCheckBoxColumn.Name = "confirmedDataGridViewCheckBoxColumn";
            this.confirmedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // schedulesTableAdapter
            // 
            this.schedulesTableAdapter.ClearBeforeFill = true;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "Routes";
            this.routesBindingSource.DataSource = this.session2_IvlevDataSet;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // fKScheduleRoutesBindingSource
            // 
            this.fKScheduleRoutesBindingSource.DataMember = "FK_Schedule_Routes";
            this.fKScheduleRoutesBindingSource.DataSource = this.routesBindingSource;
            // 
            // fKRoutesAirports31BindingSource
            // 
            this.fKRoutesAirports31BindingSource.DataMember = "FK_Routes_Airports31";
            this.fKRoutesAirports31BindingSource.DataSource = this.airportsBindingSource1;
            // 
            // routes1TableAdapter
            // 
            this.routes1TableAdapter.ClearBeforeFill = true;
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "managerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.managerForm_FormClosed);
            this.Load += new System.EventHandler(this.managerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_IvlevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKScheduleRoutesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoutesAirports31BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Session2_IvlevDataSet session2_IvlevDataSet;
        private System.Windows.Forms.BindingSource schedulesBindingSource;
        private Session2_IvlevDataSetTableAdapters.SchedulesTableAdapter schedulesTableAdapter;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private Session2_IvlevDataSetTableAdapters.AirportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.BindingSource schedulesBindingSource1;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private Session2_IvlevDataSetTableAdapters.RoutesTableAdapter routesTableAdapter;
        private System.Windows.Forms.BindingSource fKScheduleRoutesBindingSource;
        private System.Windows.Forms.BindingSource airportsBindingSource1;
        private System.Windows.Forms.BindingSource schedulesBindingSource2;
        private System.Windows.Forms.BindingSource fKRoutesAirports31BindingSource;
        private Session2_IvlevDataSetTableAdapters.Routes1TableAdapter routes1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn From;
        private System.Windows.Forms.DataGridViewComboBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
    }
}