namespace Kursach
{
    partial class ReservePlayersForm
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
            tableNoReservePlayersTeamDataGridView = new DataGridView();
            GetNoReservePlayersButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tableNoReservePlayersTeamDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableNoReservePlayersTeamDataGridView
            // 
            tableNoReservePlayersTeamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableNoReservePlayersTeamDataGridView.Location = new Point(317, 23);
            tableNoReservePlayersTeamDataGridView.Name = "tableNoReservePlayersTeamDataGridView";
            tableNoReservePlayersTeamDataGridView.RowTemplate.Height = 25;
            tableNoReservePlayersTeamDataGridView.Size = new Size(507, 385);
            tableNoReservePlayersTeamDataGridView.TabIndex = 0;
            // 
            // GetNoReservePlayersButton
            // 
            GetNoReservePlayersButton.Location = new Point(42, 143);
            GetNoReservePlayersButton.Name = "GetNoReservePlayersButton";
            GetNoReservePlayersButton.Size = new Size(222, 124);
            GetNoReservePlayersButton.TabIndex = 1;
            GetNoReservePlayersButton.Text = "Получить команды в которых нет запасных игроков";
            GetNoReservePlayersButton.UseVisualStyleBackColor = true;
            GetNoReservePlayersButton.Click += GetReservePlayersButton_Click;
            // 
            // ReservePlayersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 420);
            Controls.Add(GetNoReservePlayersButton);
            Controls.Add(tableNoReservePlayersTeamDataGridView);
            Name = "ReservePlayersForm";
            Text = "ReservePlayersForm";
            ((System.ComponentModel.ISupportInitialize)tableNoReservePlayersTeamDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tableNoReservePlayersTeamDataGridView;
        private Button GetNoReservePlayersButton;
    }
}