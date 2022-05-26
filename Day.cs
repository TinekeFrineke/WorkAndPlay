using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_And_Play
{
    internal class Day
    {
        public Day(DateTime startTime)
        {

        }

        public Day()
            : this(DateTime.Now)
        {

        }

        public enum Type { TP_Work, TP_Play };

        private void Add(Type type, DateTime time)
        {
            if (mEntries.Count() > 0)
            {
                if (time.Date != mEndTime.Date)
                    throw new Exception("Other Date");

                if (mEntries.Last().mTime > time)
                    throw new Exception("Early Date");

                if (mEntries.Last().mType == type)
                {
                    mEndTime = time;
                    return;
                }
            }

            mEntries.Add(new Entry(time, type));
            mEndTime = time;
        }

        internal struct Entry
        {
            public Entry(DateTime time, Type type)
            {
                mTime = time;
                mType = type;
            }
            public DateTime mTime;
            public Type mType;
        }

        public DateTime Date
        {
            get { return mEndTime; }
        }


        private readonly List<Entry> mEntries = new List<Entry>();
        private DateTime mEndTime;
    }
}
