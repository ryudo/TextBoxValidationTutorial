namespace TextBoxValidationTutorial
{
	using System.Windows;
	using System.Windows.Controls;

	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		/// <summary>
		/// 依存関係プロパティ バインディング機能を使うために必要
		/// </summary>
		public static readonly DependencyProperty StarNameProperty = DependencyProperty.Register(
			"StarName", typeof(string), typeof(MainWindow), new PropertyMetadata(default(string)));

		/// <summary>
		/// テキストボックスとバインディングするためのプロパティ
		/// </summary>
		public string StarName
		{
			get
			{
				return (string)this.GetValue(MainWindow.StarNameProperty);
			}

			set
			{
				this.SetValue(MainWindow.StarNameProperty, value);
			}
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// プレゼン用 テキストボックスのバリデーションエラーを捕まえることができる
		/// </summary>
		/// <param name="sender">送信オブジェクト</param>
		/// <param name="e">バリデーションエラーに関するパラメータ</param>
		private void OnValidationError(object sender, ValidationErrorEventArgs e)
		{
			if (e.Action == ValidationErrorEventAction.Added)
			{
				// バリデーションエラーが発生したときの処理を追加できます
			}
		}
	}
}
