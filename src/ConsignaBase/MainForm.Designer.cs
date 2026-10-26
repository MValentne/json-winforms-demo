namespace ConsignaBase;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null!;
    private Label lblTitulo = null!;
    private Label lblSubtitulo = null!;
    private DataGridView gridElementos = null!;
    private Label lblNombre = null!;
    private TextBox txtNombre = null!;
    private Label lblCategoria = null!;
    private TextBox txtCategoria = null!;
    private Label lblCantidad = null!;
    private TextBox txtCantidad = null!;
    private Button btnAgregar = null!;
    private Label lblEstado = null!;
    private Button btnGuardar = null!;
    private Button btnCargar = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        gridElementos = new DataGridView();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblCategoria = new Label();
        txtCategoria = new TextBox();
        lblCantidad = new Label();
        txtCantidad = new TextBox();
        btnAgregar = new Button();
        lblEstado = new Label();
        btnGuardar = new Button();
        btnCargar = new Button();
        ((System.ComponentModel.ISupportInitialize)gridElementos).BeginInit();
        SuspendLayout();

        // lblTitulo
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
        lblTitulo.Location = new Point(26, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Text = "Mi lista";

        // lblSubtitulo
        lblSubtitulo.AutoEllipsis = true;
        lblSubtitulo.ForeColor = Color.FromArgb(96, 96, 96);
        lblSubtitulo.Location = new Point(28, 56);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(846, 18);
        lblSubtitulo.Text = "Punto de partida de la consigna: la ventana está armada, la lógica es tuya.";

        // gridElementos
        gridElementos.AllowUserToAddRows = false;
        gridElementos.AllowUserToDeleteRows = false;
        gridElementos.AllowUserToResizeRows = false;
        gridElementos.AutoGenerateColumns = false;
        gridElementos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridElementos.BackgroundColor = SystemColors.Window;
        gridElementos.BorderStyle = BorderStyle.FixedSingle;
        gridElementos.ColumnHeadersHeight = 34;
        gridElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridElementos.Font = new Font("Segoe UI", 11F);
        gridElementos.Location = new Point(28, 84);
        gridElementos.MultiSelect = false;
        gridElementos.Name = "gridElementos";
        gridElementos.RowHeadersVisible = false;
        gridElementos.RowTemplate.Height = 28;
        gridElementos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridElementos.Size = new Size(846, 258);
        gridElementos.TabIndex = 0;

        DataGridViewTextBoxColumn colNombre = new()
        {
            DataPropertyName = "Nombre",
            FillWeight = 45F,
            HeaderText = "Nombre",
            Name = "colNombre",
        };

        DataGridViewTextBoxColumn colCategoria = new()
        {
            DataPropertyName = "Categoria",
            FillWeight = 35F,
            HeaderText = "Categoría",
            Name = "colCategoria",
        };

        DataGridViewTextBoxColumn colCantidad = new()
        {
            DataPropertyName = "Cantidad",
            FillWeight = 20F,
            HeaderText = "Cantidad",
            Name = "colCantidad",
        };

        gridElementos.Columns.AddRange(colNombre, colCategoria, colCantidad);

        // lblNombre
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(28, 362);
        lblNombre.Name = "lblNombre";
        lblNombre.Text = "Nombre";

        // txtNombre
        txtNombre.Location = new Point(102, 358);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(200, 27);
        txtNombre.TabIndex = 1;

        // lblCategoria
        lblCategoria.AutoSize = true;
        lblCategoria.Location = new Point(330, 362);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Text = "Categoría";

        // txtCategoria
        txtCategoria.Location = new Point(410, 358);
        txtCategoria.Name = "txtCategoria";
        txtCategoria.Size = new Size(180, 27);
        txtCategoria.TabIndex = 2;

        // lblCantidad
        lblCantidad.AutoSize = true;
        lblCantidad.Location = new Point(614, 362);
        lblCantidad.Name = "lblCantidad";
        lblCantidad.Text = "Cantidad";

        // txtCantidad
        txtCantidad.Location = new Point(694, 358);
        txtCantidad.Name = "txtCantidad";
        txtCantidad.Size = new Size(90, 27);
        txtCantidad.TabIndex = 3;

        // btnAgregar
        btnAgregar.Location = new Point(798, 356);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(76, 30);
        btnAgregar.TabIndex = 4;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = true;
        btnAgregar.Click += btnAgregar_Click;

        // lblEstado
        lblEstado.AutoEllipsis = true;
        lblEstado.ForeColor = Color.FromArgb(96, 96, 96);
        lblEstado.Location = new Point(28, 404);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(846, 22);
        lblEstado.Text = "0 elementos en la lista.";

        // btnGuardar
        btnGuardar.Location = new Point(634, 500);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(116, 34);
        btnGuardar.TabIndex = 5;
        btnGuardar.Text = "Guardar JSON";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += btnGuardar_Click;

        // btnCargar
        btnCargar.Location = new Point(758, 500);
        btnCargar.Name = "btnCargar";
        btnCargar.Size = new Size(116, 34);
        btnCargar.TabIndex = 6;
        btnCargar.Text = "Cargar JSON";
        btnCargar.UseVisualStyleBackColor = true;
        btnCargar.Click += btnCargar_Click;

        // MainForm
        AcceptButton = btnAgregar;
        ClientSize = new Size(902, 560);
        Controls.Add(btnCargar);
        Controls.Add(btnGuardar);
        Controls.Add(lblEstado);
        Controls.Add(btnAgregar);
        Controls.Add(txtCantidad);
        Controls.Add(lblCantidad);
        Controls.Add(txtCategoria);
        Controls.Add(lblCategoria);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        Controls.Add(gridElementos);
        Controls.Add(lblSubtitulo);
        Controls.Add(lblTitulo);
        MinimumSize = new Size(820, 520);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Mi lista";
        ((System.ComponentModel.ISupportInitialize)gridElementos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
