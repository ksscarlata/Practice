using System;
using System.Collections.Generic;
using System.Text;

namespace Webasign.User
{
	public class User
	{
		private string _userName;
		private string _passWord;
		private int _idNumber;
		private string _realName;
		private int _age;

		public User() //DEFAULT
		{
            this._userName = "No entry.";
            this._passWord = "No entry.";
            this._idNumber = 0;
            this._realName = "No entry.";
            this._age = 0;
		}

		public User(string UserName, string PassWord, int IdNumber, string RealName, int Age) //PARAMETERIZED
		{
            this._userName = UserName;
            this._passWord = PassWord;
            this._idNumber = IdNumber;
            this._realName = RealName;
            this._age = Age;
        }

		public User(User u) //COPY
		{
            this._userName = u._userName;
            this._passWord = u._passWord;
            this._idNumber = u._idNumber;
            this._realName = u._realName;
            this._age = u._age;
        }

		public string UserName
		{
			get
			{
                return _userName;
			}
			set
			{
                _userName = value;
			}
		}

		public string PassWord
		{
			get
			{
                return _passWord;
			}
			set
			{
                _passWord = value;
			}
		}

		public int IdNumber
		{
			get
			{
                return _idNumber;
			}
            set
            {
                _idNumber = value;
            }
            
		}

		public string RealName
		{
			get
			{
                return _realName;
			}
            set
            {
                _realName = value;
            }
		}

		public int Age
		{
			get
			{
                return _age;
			}
			set
			{
                _age = value;
			}
		}

		public void ViewGrades_Transcripts(string UserName, int IdNumber) //RETRIEVE GRADES WITH USERNAME AND ID#
		{
			throw new NotImplementedException();
		}

		public void Login(string UserName, string PassWord) //GAIN ACCESS WITH USERNAME AND ID#
		{
            //IF USERNAME = VALID FACULTY, STUDENT, ETC
                // && PASSWORD = VALID
                    //GAIN ACCESS  
			throw new NotImplementedException();
		}
	}
}
