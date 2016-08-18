/*
 * Created by SharpDevelop.
 * User: albe
 * Date: 8/16/2016
 * Time: 1:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ThriftServer
{
	/// <summary>
	/// Description of OpenFileHandler.
	/// </summary>
	public class OpenFileHandler:OpenFileService.Iface
	{
		public FileInf fileToOpen;
		public OpenFileHandler()
		{
		}
		
		
		
		public bool openFile(FileInf info, string parameters)
		{
			
			System.Diagnostics.Process.Start(info.FileName);
			return true;
		}
		
		public IAsyncResult Begin_openFile(AsyncCallback callback, object state, FileInf info, string parameters)
		{
			throw new NotImplementedException();
		}
		
		public bool End_openFile(IAsyncResult asyncResult)
		{
			throw new NotImplementedException();
		}
		
		public List<FileInf> listFolder(string path)
		{
			DirectoryInfo di=new DirectoryInfo(path);
			FileInfo[] files=di.GetFiles();
			DirectoryInfo[] directories=di.GetDirectories();
			List<FileInf>aux_list=new List<FileInf>();
			foreach (DirectoryInfo element in directories) {
				FileInf aux_file=new FileInf();
				aux_file.FileName=element.FullName;
				aux_file.Extension="";
				aux_file.IsDir=true;
				aux_list.Add(aux_file);
			}
			foreach (FileInfo element in files) {
				FileInf aux_file=new FileInf();
				aux_file.FileName=element.FullName;
				aux_file.Extension=element.Extension.Replace(".","");
				aux_file.IsDir=false;
				aux_list.Add(aux_file);
			}
			return aux_list;
		}
		
		public IAsyncResult Begin_listFolder(AsyncCallback callback, object state, string path)
		{
			throw new NotImplementedException();
		}
		
		public List<FileInf> End_listFolder(IAsyncResult asyncResult)
		{
			throw new NotImplementedException();
		}
	}
}
