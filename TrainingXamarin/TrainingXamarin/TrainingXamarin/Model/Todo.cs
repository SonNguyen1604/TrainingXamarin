﻿using System;

namespace TrainingXamarin.Model
{
    public class Todo : BaseModel
    {
        private string mTitle;
        private string mDescription;
        private DateTime mFrom;
        private DateTime mTo;
        private bool mIsDone;

        public string Title
        {
            set
            {
                mTitle = value;
                pushPropertyChanged("Title");
            }
            get
            {
                return mTitle;
            }
        }

        public string Description
        {
            set
            {
                mDescription = value;
                pushPropertyChanged("Description");
            }
            get
            {
                return mDescription;
            }
        }

        public DateTime From
        {
            set
            {
                mFrom = value;
                pushPropertyChanged("From");
            }
            get
            {
                return mFrom;
            }
        }

        public DateTime To
        {
            set
            {
                mTo = value;
                pushPropertyChanged("To");
            }
            get
            {
                return mTo;
            }
        }

        public bool IsDone
        {
            set
            {
                if (mIsDone != value)
                {
                    mIsDone = value;
                    pushPropertyChanged("IsDone");
                }
            }
            get
            {
                return mIsDone;
            }
        }
    }
}
