namespace COMP003A.LectureActivity6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student student1 = new Student("Alex", 20);
			Student student2 = new Student("Jordan", 22);

			student1.DisplayInfo();
			student2.DisplayInfo();

			student1.Age = 25;

			student1.DisplayInfo();
			student2.DisplayInfo();
		}
	}
}
