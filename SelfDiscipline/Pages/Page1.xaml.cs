using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SelfDiscipline.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void BindingDataToTextBox()
        {
            // Title
            ObservableCollection<AppChallenge> mainTitle = new ObservableCollection<AppChallenge>();
            mainTitle.Add(new AppChallenge()
            {
                Content = "Điều nhỏ BÉ, ý nghĩa LỚN, hạnh phúc NHIỀU."
            });
            lblMainTitle.DataContext = mainTitle;

            //// Goal
            //ObservableCollection<AppChallenge> goalTitle = new ObservableCollection<AppChallenge>();
            //goalTitle.Add(new AppChallenge()
            //{
            //    Content = "Mục tiêu"
            //});
            //lblGoalTitle.DataContext = goalTitle;

            //
            ObservableCollection<AppChallenge> dayChallenge1 = new ObservableCollection<AppChallenge>();
            dayChallenge1.Add(new AppChallenge()
            {
                Content = "Không làm cú, ngủ sớm dậy sớm, bảo đảm giấc ngủ 7 tiếng"
            });
            txtDay1.DataContext = dayChallenge1;

            ObservableCollection<AppChallenge> weekChallenge1 = new ObservableCollection<AppChallenge>();
            weekChallenge1.Add(new AppChallenge()
            {
                Content = "Gọi điện cho bố mẹ ít nhất 1 lần"
            });
            txtWeek1.DataContext = weekChallenge1;

            ObservableCollection<AppChallenge> monthChallenge1 = new ObservableCollection<AppChallenge>();
            monthChallenge1.Add(new AppChallenge()
            {
                Content = "Gửi một lời hỏi thăm cho người bạn đã lâu không liên lạc"
            });
            txtMonth1.DataContext = monthChallenge1;

            ObservableCollection<AppChallenge> quarterChallenge1 = new ObservableCollection<AppChallenge>();
            quarterChallenge1.Add(new AppChallenge()
            {
                Content = "Dành cho bản thân một chuyến du lịch với hành trình ngắn khoảng 2-3 ngày"
            });
            txtQuarter1.DataContext = quarterChallenge1;

            ObservableCollection<AppChallenge> yearChallenge1 = new ObservableCollection<AppChallenge>();
            yearChallenge1.Add(new AppChallenge()
            {
                Content = "Dành cho bản thân một chuyến du lịch từ 5 ngày trở lên"
            });
            txtYear1.DataContext = yearChallenge1;

            //
            ObservableCollection<AppChallenge> dayChallenge2 = new ObservableCollection<AppChallenge>();
            dayChallenge2.Add(new AppChallenge()
            {
                Content = "Dành 20-60 phút để học tiếng Anh, đọc sách"
            });
            txtDay2.DataContext = dayChallenge2;

            ObservableCollection<AppChallenge> weekChallenge2 = new ObservableCollection<AppChallenge>();
            weekChallenge2.Add(new AppChallenge()
            {
                Content = "Dành 3-12 tiếng học tập hoặc nâng cao một kỹ năng nào đó"
            });
            txtWeek2.DataContext = weekChallenge2;

            ObservableCollection<AppChallenge> monthChallenge2 = new ObservableCollection<AppChallenge>();
            monthChallenge2.Add(new AppChallenge()
            {
                Content = "Dành một niềm vui bất ngờ cho người bạn yêu thương"
            });
            txtMonth2.DataContext = monthChallenge2;

            ObservableCollection<AppChallenge> quarterChallenge2 = new ObservableCollection<AppChallenge>();
            quarterChallenge2.Add(new AppChallenge()
            {
                Content = "Tặng cho bố mẹ một món quà"
            });
            txtQuarter2.DataContext = quarterChallenge2;

            ObservableCollection<AppChallenge> yearChallenge2 = new ObservableCollection<AppChallenge>();
            yearChallenge2.Add(new AppChallenge()
            {
                Content = "Kiểm tra sức khỏe toàn diện một lần, dẫn theo cả cha mẹ, người yêu"
            });
            txtYear2.DataContext = yearChallenge2;
        }
    }

    public class AppTitle
    {
        public string Content { get; set; }
    }
    public class AppChallenge
    {
        public string Content { get; set; }
    }
}
