namespace csharp ThriftServer
namespace php ThriftSampleBundle.Util
struct FileInf
{
  1: string FileName,
  2: string extension,
  3: bool isDir
}
service OpenFileService{
	bool openFile (1:FileInf info,2:string parameters),
	list <FileInf> listFolder(1:string path),
}