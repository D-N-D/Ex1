using System;
namespace Post
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _vote;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        public int Vote
        {
            get { return _vote; }
        }

        public void UpVote()
        {
            _vote = _vote + 1;
        }

        public void DownVote ()
        {
            _vote = _vote - 1;
        }

        public Post()
        {

		 _vote = 0;

	    }

    }
}
