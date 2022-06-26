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

        public Dictionary<Type, String> Durations()
        {
            //Dictionary<Type, TimeSpan> dict = new Dictionary<Type, TimeSpan>();
            //dict[Type::TP_Work] = 0;
            //dict[Type::TP_Play] = 0;
            //foreach (Entry entry in mEntries)
            //{
            //    dict[entry.mType].Add(entry.
            //}

            Dictionary<Type, String> durations = new Dictionary<Type, String>();
            return durations;

        }

        private void Add(Type type, DateTime time)
        {
            if (mEntries.Count() > 0)
            {
                // In some cases we can exit early: In an error
                // condition or when the type equals the last entry.
                if (time.Date != mEndTime.Date)
                    throw new Exception("Other Date");

                if (mEntries.Last().mStartTime > time)
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
                mStartTime = time;
                mType = type;
            }
            public DateTime mStartTime;
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
