#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Calendar;

namespace SampleBrowser.Maui.Calendar.SfCalendar
{
    /// <summary>
    /// Interaction logic for GettingStarted.xaml
    /// </summary>
    public partial class HighlightDates : SampleView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightDates" /> class.
        /// </summary>
        public HighlightDates()
        {
            InitializeComponent();
            comboBox.ItemsSource = new List<string>() { "Light - Teal", "Light - Blue", "Light - Navy Blue", "Dark - Blue" };
            comboBox.SelectedIndex = 0;

            Syncfusion.Maui.Calendar.SfCalendar calendar = this.HighlightCalendar;
#if IOS || MACCATALYST
            this.border.IsVisible = true;
#if MACCATALYST
            this.border.Stroke = Color.FromArgb("#E6E6E6");
#else
            this.border.Stroke = Colors.Transparent;
#endif
            calendar = this.HighlightCalendar1;
#else
            this.frame.IsVisible = true;
#if ANDROID
            this.frame.BorderColor = Colors.Transparent;
#else
            this.frame.BorderColor = Color.FromArgb("#E6E6E6");
#endif
#endif

            calendar.HeaderView.TextStyle = new CalendarTextStyle()
            {
                TextColor = Color.FromArgb("#FFFFFF")
            };
            this.UpdateLightTealTheme(calendar);
            calendar.SelectableDayPredicate = (date) =>
            {
                if (date == DateTime.Now.Date)
                {
                    return true;
                }

                if (date.Day % 9 == 0)
                {
                    if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
                    {
                        calendar.MonthView.SpecialDates.Add(date);
                    }
                }

                if (date.Day % 11 == 0)
                {
                    if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
                    {
                        return false;
                    }
                }

                return true;
            };
        }

        /// <summary>
        ///  When the page disappears due to navigating away from the page within the application.
        /// </summary>
        public override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        private void comboBox_SelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                string? theme = e.CurrentSelection[0].ToString();
                if (theme == null)
                {
                    return;
                }

                Syncfusion.Maui.Calendar.SfCalendar calendar = this.HighlightCalendar;
#if IOS || MACCATALYST
            calendar = this.HighlightCalendar1;
#endif

                if (theme == "Light - Teal")
                {
                    this.UpdateLightTealTheme(calendar);
                }
                else if (theme == "Light - Blue")
                {
                    this.UpdateLightBlueTheme(calendar);
                }
                else if (theme == "Light - Navy Blue")
                {
                    this.UpdateLightNavyBlueTheme(calendar);
                }
                else if (theme == "Dark - Blue")
                {
                    this.UpdateDarkBlueTheme(calendar);
                }
            }
        }

        private void UpdateLightTealTheme(Syncfusion.Maui.Calendar.SfCalendar calendar)
        {
            calendar.HeaderView.Background = Color.FromArgb("#2A5D59");
            calendar.TodayHighlightBrush = Color.FromArgb("#67D1BF");
            calendar.SelectionBackground = Color.FromArgb("#67D1BF");
            calendar.MonthView = new CalendarMonthView()
            {
                SpecialDates = calendar.MonthView.SpecialDates,
                WeekendDays = new List<DayOfWeek>() { DayOfWeek.Sunday, DayOfWeek.Saturday },
                HeaderView = new CalendarMonthHeaderView()
                {
                    Background = Color.FromArgb("#2A5D59"),
                    TextStyle = new CalendarTextStyle()
                    {
                        TextColor = Color.FromArgb("#FFFFFF")
                    },
                },
                Background = Color.FromArgb("#F0FFFB"),
                TextStyle= new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#2A5D59")
                },
                TrailingLeadingDatesBackground = Color.FromArgb("#F0FFFB"),
                TrailingLeadingDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#2A5D59").WithAlpha(0.6f)
                },
                WeekendDatesBackground = Color.FromArgb("#E2F9F3"),
                WeekendDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#2A5D59")
                },
                SpecialDatesBackground = Color.FromArgb("#FFEFD2"),
                SpecialDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#8B6010")
                },
                DisabledDatesBackground = Color.FromArgb("#E1F0EC"),
                DisabledDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#2A5D59").WithAlpha(0.6f)
                },
                TodayBackground = Color.FromArgb("#F0FFFB"),
                TodayTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#67D1BF")
                },
                SelectionTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#004E48")
                }
            };
        }

        private void UpdateLightBlueTheme(Syncfusion.Maui.Calendar.SfCalendar calendar)
        {
            calendar.HeaderView.Background = Color.FromArgb("#2242A9");
            calendar.TodayHighlightBrush = Color.FromArgb("#87B9FF");
            calendar.SelectionBackground = Color.FromArgb("#87B9FF");
            calendar.MonthView = new CalendarMonthView()
            {
                SpecialDates = calendar.MonthView.SpecialDates,
                WeekendDays = new List<DayOfWeek>() { DayOfWeek.Sunday, DayOfWeek.Saturday },
                HeaderView = new CalendarMonthHeaderView()
                {
                    Background = Color.FromArgb("#2242A9"),
                    TextStyle = new CalendarTextStyle()
                    {
                        TextColor = Color.FromArgb("#FFFFFF")
                    },
                },
                Background = Color.FromArgb("#F0F6FE"),
                TextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#233B85")
                },
                TrailingLeadingDatesBackground = Color.FromArgb("#F0F6FE"),
                TrailingLeadingDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#233B85").WithAlpha(0.6f)
                },
                WeekendDatesBackground = Color.FromArgb("#DEEAFC"),
                WeekendDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#233B85")
                },
                SpecialDatesBackground = Color.FromArgb("#EAD6FF"),
                SpecialDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#8F49D0")
                },
                DisabledDatesBackground = Color.FromArgb("#E5EEFA"),
                DisabledDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#233B85").WithAlpha(0.6f)
                },
                TodayBackground = Color.FromArgb("#F0F6FE"),
                TodayTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#87B9FF")
                },
                SelectionTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#14234F")
                }
            };
        }

        private void UpdateLightNavyBlueTheme(Syncfusion.Maui.Calendar.SfCalendar calendar)
        {
            calendar.HeaderView.Background = Color.FromArgb("#27187E");
            calendar.TodayHighlightBrush = Color.FromArgb("#F08B34");
            calendar.SelectionBackground = Color.FromArgb("#F08B34");
            calendar.MonthView = new CalendarMonthView()
            {
                SpecialDates = calendar.MonthView.SpecialDates,
                WeekendDays = new List<DayOfWeek>() { DayOfWeek.Sunday, DayOfWeek.Saturday },
                HeaderView = new CalendarMonthHeaderView()
                {
                    Background = Color.FromArgb("#27187E"),
                    TextStyle = new CalendarTextStyle()
                    {
                        TextColor = Color.FromArgb("#FFFFFF")
                    },
                },
                Background = Color.FromArgb("#EBEEFF"),
                TextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#27187E")
                },
                TrailingLeadingDatesBackground = Color.FromArgb("#EBEEFF"),
                TrailingLeadingDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#27187E").WithAlpha(0.6f)
                },
                WeekendDatesBackground = Color.FromArgb("#DDE2FF"),
                WeekendDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#27187E")
                },
                SpecialDatesBackground = Color.FromArgb("#ECD5FF"),
                SpecialDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#5A00A5")
                },
                DisabledDatesBackground = Color.FromArgb("#E5EEFA"),
                DisabledDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#27187E").WithAlpha(0.6f)
                },
                TodayBackground = Color.FromArgb("#EBEEFF"),
                TodayTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#F08B34")
                },
                SelectionTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#27187E")
                }
            };
        }

        private void UpdateDarkBlueTheme(Syncfusion.Maui.Calendar.SfCalendar calendar)
        {
            calendar.HeaderView.Background = Color.FromArgb("#143F85");
            calendar.TodayHighlightBrush = Color.FromArgb("#6DC7E1");
            calendar.SelectionBackground = Color.FromArgb("#6DC7E1");
            calendar.MonthView = new CalendarMonthView()
            {
                SpecialDates = calendar.MonthView.SpecialDates,
                WeekendDays = new List<DayOfWeek>() { DayOfWeek.Sunday, DayOfWeek.Saturday },
                HeaderView = new CalendarMonthHeaderView()
                {
                    Background = Color.FromArgb("#143F85"),
                    TextStyle = new CalendarTextStyle()
                    {
                        TextColor = Color.FromArgb("#FFFFFF")
                    },
                },
                Background = Color.FromArgb("#3076B1"),
                TextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#FFFFFF")
                },
                TrailingLeadingDatesBackground = Color.FromArgb("#3076B1"),
                TrailingLeadingDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#FFFFFF").WithAlpha(0.6f)
                },
                WeekendDatesBackground = Color.FromArgb("#3F95C2"),
                WeekendDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#FFFFFF")
                },
                SpecialDatesBackground = Color.FromArgb("#FFCF55"),
                SpecialDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#000000")
                },
                DisabledDatesBackground = Color.FromArgb("#1A65A5"),
                DisabledDatesTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#FFFFFF").WithAlpha(0.6f)
                },
                TodayBackground = Color.FromArgb("#3076B1"),
                TodayTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#6DC7E1")
                },
                SelectionTextStyle = new CalendarTextStyle()
                {
                    TextColor = Color.FromArgb("#000000").WithAlpha(0.87f)
                }
            };
        }
    }
}