﻿using System;
using System.Windows;
using Infragistics;
using Infragistics.Controls.Schedules;
using Infragistics.Samples.Framework;
using Infragistics.Samples.Shared.Tools;

namespace IGSchedule.Samples.Editing
{
    /// <summary>
    /// Interaction logic for MonthViewEvents.xaml
    /// </summary>
    public partial class MonthViewEvents : SampleContainer
    {
        private int innerCounter;

        public MonthViewEvents()
        {
            InitializeComponent();
        }
        

        void XamScheduleDataManager_ActivityRemoving(object sender, ActivityRemovingEventArgs e)
        {
            AddToLog("XamScheduleDataManager_ActivityRemoving");
        }

        void XamScheduleDataManager_ActivityRemoved(object sender, ActivityRemovedEventArgs e)
        {
            AddToLog("XamScheduleDataManager_ActivityRemoved");
        }

        void XamScheduleDataManager_ActivityChanging(object sender, ActivityChangingEventArgs e)
        {
            AddToLog("XamScheduleDataManager_ActivityChanging");
        }

        void XamScheduleDataManager_ActivityChanged(object sender, ActivityChangedEventArgs e)
        {
            AddToLog("XamScheduleDataManager_ActivityChanged");
        }

        void XamScheduleDataManager_ActivityAdding(object sender, ActivityAddingEventArgs e)
        {
            AddToLog("XamScheduleDataManager_ActivityAdding");
        }

        void XamScheduleDataManager_ActivityAdded(object sender, ActivityAddedEventArgs e)
        {
            AddToLog("XamScheduleDataManager_ActivityAdded");
        }

        void XamScheduleDataManager_ActivityDialogDisplaying(object sender, ActivityDialogDisplayingEventArgs e)
        {
            AddToLog("XamScheduleDataManager_ActivityDialogDisplaying");
        }

        void monthView_SelectedTimeRangeChanged(object sender, RoutedPropertyChangedEventArgs<DateRange?> e)
        {
            AddToLog("XamMonthView_SelectedTimeRangeChanged");
        }

        void monthView_ActiveCalendarChanged(object sender, RoutedPropertyChangedEventArgs<ResourceCalendar> e)
        {
            AddToLog("XamMonthView_ActiveCalendarChanged");
        }

        void monthView_SelectedActivitiesChanged(object sender, SelectedActivitiesChangedEventArgs e)
        {
            AddToLog("XamMonthView_SelectedActivitiesChanged");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            innerCounter = 0;
            txtEvents.Text = string.Empty;
        }

        private bool AddToLog(string Text)
        {
            if (txtEvents != null)
            {
                innerCounter++;
                txtEvents.Text = innerCounter + DateTime.Now.ToString(" - hh:mm:ss - ") + Text + Environment.NewLine + txtEvents.Text;

            }
            return txtEvents != null;
        }
    }
}