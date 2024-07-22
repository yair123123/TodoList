namespace TodoList
{
    partial class Todos
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
            textboxTask = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label_title = new ReaLTaiizor.Controls.MaterialLabel();
            label_date = new ReaLTaiizor.Controls.MaterialLabel();
            hopeDatePicker = new ReaLTaiizor.Controls.HopeDatePicker();
            checkbox_isDone = new ReaLTaiizor.Controls.MaterialCheckBox();
            dataGridView_tasks = new DataGridView();
            button_action = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView_tasks).BeginInit();
            SuspendLayout();
            // 
            // textboxTask
            // 
            textboxTask.AnimateReadOnly = false;
            textboxTask.AutoCompleteMode = AutoCompleteMode.None;
            textboxTask.AutoCompleteSource = AutoCompleteSource.None;
            textboxTask.BackgroundImageLayout = ImageLayout.None;
            textboxTask.CharacterCasing = CharacterCasing.Normal;
            textboxTask.Depth = 0;
            textboxTask.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textboxTask.HideSelection = true;
            textboxTask.LeadingIcon = null;
            textboxTask.Location = new Point(90, 262);
            textboxTask.Margin = new Padding(7, 5, 7, 5);
            textboxTask.MaxLength = 32767;
            textboxTask.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textboxTask.Name = "textboxTask";
            textboxTask.PasswordChar = '\0';
            textboxTask.PrefixSuffixText = null;
            textboxTask.ReadOnly = false;
            textboxTask.RightToLeft = RightToLeft.No;
            textboxTask.SelectedText = "";
            textboxTask.SelectionLength = 0;
            textboxTask.SelectionStart = 0;
            textboxTask.ShortcutsEnabled = true;
            textboxTask.Size = new Size(663, 48);
            textboxTask.TabIndex = 0;
            textboxTask.TabStop = false;
            textboxTask.TextAlign = HorizontalAlignment.Left;
            textboxTask.TrailingIcon = null;
            textboxTask.UseSystemPasswordChar = false;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Depth = 0;
            label_title.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_title.Location = new Point(90, 191);
            label_title.Margin = new Padding(7, 0, 7, 0);
            label_title.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_title.Name = "label_title";
            label_title.Size = new Size(87, 19);
            label_title.TabIndex = 1;
            label_title.Text = "Task details";
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Depth = 0;
            label_date.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_date.Location = new Point(90, 429);
            label_date.Margin = new Padding(7, 0, 7, 0);
            label_date.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_date.Name = "label_date";
            label_date.Size = new Size(66, 19);
            label_date.TabIndex = 3;
            label_date.Text = "Due Date";
            // 
            // hopeDatePicker
            // 
            hopeDatePicker.BackColor = Color.White;
            hopeDatePicker.BorderColor = Color.FromArgb(220, 223, 230);
            hopeDatePicker.Date = new DateTime(2024, 7, 22, 0, 0, 0, 0);
            hopeDatePicker.DayNames = "MTWTFSS";
            hopeDatePicker.DaysTextColor = Color.FromArgb(96, 98, 102);
            hopeDatePicker.DayTextColorA = Color.FromArgb(48, 49, 51);
            hopeDatePicker.DayTextColorB = Color.FromArgb(144, 147, 153);
            hopeDatePicker.HeaderFormat = "{0} Y - {1} M";
            hopeDatePicker.HeaderTextColor = Color.FromArgb(48, 49, 51);
            hopeDatePicker.HeadLineColor = Color.FromArgb(228, 231, 237);
            hopeDatePicker.HoverColor = Color.FromArgb(235, 238, 245);
            hopeDatePicker.Location = new Point(90, 497);
            hopeDatePicker.Margin = new Padding(7, 5, 7, 5);
            hopeDatePicker.Name = "hopeDatePicker";
            hopeDatePicker.NMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker.NMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker.NYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker.NYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker.PMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker.PMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker.PYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker.PYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker.SelectedBackColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker.SelectedTextColor = Color.White;
            hopeDatePicker.Size = new Size(250, 270);
            hopeDatePicker.TabIndex = 4;
            hopeDatePicker.Text = "hopeDatePicker1";
            hopeDatePicker.ValueTextColor = Color.FromArgb(43, 133, 228);
            // 
            // checkbox_isDone
            // 
            checkbox_isDone.AutoSize = true;
            checkbox_isDone.Depth = 0;
            checkbox_isDone.Location = new Point(90, 1255);
            checkbox_isDone.Margin = new Padding(0);
            checkbox_isDone.MouseLocation = new Point(-1, -1);
            checkbox_isDone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkbox_isDone.Name = "checkbox_isDone";
            checkbox_isDone.ReadOnly = false;
            checkbox_isDone.Ripple = true;
            checkbox_isDone.Size = new Size(72, 37);
            checkbox_isDone.TabIndex = 5;
            checkbox_isDone.Text = "Done";
            checkbox_isDone.UseAccentColor = false;
            checkbox_isDone.UseVisualStyleBackColor = true;
            checkbox_isDone.CheckedChanged += checkbox_isDone_CheckedChanged;
            // 
            // dataGridView_tasks
            // 
            dataGridView_tasks.AllowUserToAddRows = false;
            dataGridView_tasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_tasks.Location = new Point(874, 262);
            dataGridView_tasks.Margin = new Padding(7, 5, 7, 5);
            dataGridView_tasks.Name = "dataGridView_tasks";
            dataGridView_tasks.RowHeadersWidth = 51;
            dataGridView_tasks.Size = new Size(724, 943);
            dataGridView_tasks.TabIndex = 6;
            dataGridView_tasks.CellContentClick += dataGridView_tasks_CellContentClick;
            // 
            // button_action
            // 
            button_action.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_action.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_action.Depth = 0;
            button_action.HighEmphasis = true;
            button_action.Icon = null;
            button_action.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            button_action.Location = new Point(491, 1252);
            button_action.Margin = new Padding(10, 11, 10, 11);
            button_action.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            button_action.Name = "button_action";
            button_action.NoAccentTextColor = Color.Empty;
            button_action.Size = new Size(85, 36);
            button_action.TabIndex = 7;
            button_action.Text = "ADD|EDIT";
            button_action.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            button_action.UseAccentColor = false;
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // Todos
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1879, 1428);
            Controls.Add(button_action);
            Controls.Add(dataGridView_tasks);
            Controls.Add(checkbox_isDone);
            Controls.Add(hopeDatePicker);
            Controls.Add(label_date);
            Controls.Add(label_title);
            Controls.Add(textboxTask);
            Margin = new Padding(7, 5, 7, 5);
            Name = "Todos";
            Padding = new Padding(7, 131, 7, 5);
            Text = "Todos";
            ((System.ComponentModel.ISupportInitialize)dataGridView_tasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit textboxTask;
        private ReaLTaiizor.Controls.MaterialLabel label_title;
        private ReaLTaiizor.Controls.MaterialLabel label_date;
        private ReaLTaiizor.Controls.HopeDatePicker hopeDatePicker;
        private ReaLTaiizor.Controls.MaterialCheckBox checkbox_isDone;
        private DataGridView dataGridView_tasks;
        private ReaLTaiizor.Controls.MaterialButton button_action;
    }
}