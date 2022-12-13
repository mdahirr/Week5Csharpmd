using SerialisationApp;


string path =
        Environment.GetFolderPath(
        Environment.SpecialFolder.MyDocuments);

Trainee trainee = new Trainee
{
    FirstName = "Mo",
    LastName = "Dahir",
    SpartaNo = 100
};

Course eng152 = new Course
{
    Title = "Engineering 152",
    Subject = "C# Development"
};
eng152.AddTrainee(trainee);
eng152.AddTrainee(
    new Trainee
    {
        FirstName = "Laura",
        LastName = "Tozer",
        SpartaNo = 1
    });

var serialiser = new SerialiserXml();
var serialiserJson = new SerialiserJSON();

string fullTraineePathXML = path + "\\Trainee.xml";
string fullCoursePathXML = path + "\\Course.xml";
string fullTraineePathJson = path + "\\Trainee.json";
string fullCoursePathJson = path + "\\Course.json";

Serialise(trainee, serialiser, fullTraineePathXML);

Trainee traineeDeserialisedXML = Deserialise<Trainee>(serialiser, fullTraineePathXML);

Serialise(eng152, serialiser, fullCoursePathXML);
Course courseDeserialisedXML = Deserialise<Course>(serialiser, fullCoursePathXML);

Serialise(trainee, serialiserJson, fullTraineePathJson);
Trainee traineeDeserialisedJson = Deserialise<Trainee>(serialiserJson, fullCoursePathJson);

Serialise(trainee, serialiserJson, fullTraineePathJson);
Course courseDeserialisedJson = Deserialise<Course>(serialiserJson, fullCoursePathJson);


Console.WriteLine(traineeDeserialisedXML);
Console.WriteLine(courseDeserialisedXML);
Console.WriteLine(traineeDeserialisedJson);
Console.WriteLine(courseDeserialisedJson);

static void Serialise<T>(T trainee, ISerialiser serialiser, string toPath)
{
    serialiser.Serialise(trainee, toPath);
}

static T Deserialise<T>(ISerialiser serialiser, string fromPath)
{
    return serialiser.Deserialise<T>(fromPath);
}