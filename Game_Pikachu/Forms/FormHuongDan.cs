using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Pikachu.Forms
{
    public partial class FormHuongDan : Form
    {
        public FormHuongDan()
        {
            InitializeComponent();
            this.Load_HuongDan();
        }
        private void Load_HuongDan()
        {
            this.richTextBox1.Text = "Xin chào các bạn nhỏ :))) Đây là hướng dẫn chơi game Pokemon\n" +
                "Để chơi game nhiệm vụ của các bạn rất đơn giản đó là tìm kiếm và chọn 2 con Pokemon giống nhau để ăn chúng.\n" +
                "Để 2 con Pokemon có thể ăn nhau điều kiện là:\n" +
                "- Hai con đó phải ở cạnh nhau\n" +
                "- Hoặc có đường đi từ con này tới con kia, với điều kiện đường đi đó gấp khúc tối đa 2 lần.\n" +
                "- Có đường đi nghĩa là trên đường đi tới nhau không có con pokemon nào cản đường.\n" +
                "Khi ăn xong 1 cặp, cặp pokemon đó sẽ biến mất và bạn được 10 điểm cho mỗi cặp ăn được.\n" +
                "Chú ý: Bạn hãy cố gắng tìm kiếm thật nhanh nhé và chú ý thời gian còn lại phía trên màn hình, Hết thời gian mà bạn chưa ăn hết là bạn sẽ thua đó.\n" +
                "Đừng quá lo lắng khi cảm thấy khó khăn,khi quá bế tắc hãy sử dụng gợi ý bằng cách ấn vào nút [?] để được gợi ý nhé\n" +
                "Chúc bạn vui vẻ!!!!!!!!!";
        }
    }
}
