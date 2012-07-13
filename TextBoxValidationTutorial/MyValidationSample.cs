namespace TextBoxValidationTutorial
{
	using System;
	using System.Globalization;
	using System.Windows.Controls;

	/// <summary>
	/// バリデーションルールのクラス
	/// </summary>
	public class MyValidationSample : ValidationRule
	{
		/// <summary>
		/// バリデーションを行うメソッド
		/// </summary>
		/// <param name="value">入力値</param>
		/// <param name="cultureInfo">カルチャ</param>
		/// <returns>バリデーション結果を示す戻り値</returns>
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			double number = 0;
			try
			{
				number = Convert.ToDouble(value.ToString());
			}
			catch (Exception)
			{
				return new ValidationResult(false, "値が数値じゃありません");
			}

			return number == 0.0 ? new ValidationResult(false, "値が数値じゃありません") : new ValidationResult(true, null);
		}
	}
}
