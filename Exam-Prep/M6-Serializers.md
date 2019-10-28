# Exam Preparation 70-483 Programming in C#

## Serializer

```C#
[Serializable]
public class Unit {
    public string Name { get; set; }
    public int HP { get; set; }
    public int Energy { get; set; }
    public int MineralCost { get; set; }
    public int GasCost { get; set; }
}

static class DraphonyExtension {
    static void Serialize(this ProfileInfo o) {
        // TODO: please complete
    }
}
```

You want to write a method, that serializes ProfileInfo objects into JSON. Which of the following class should you use?
1. DataContractJsonSerializer
2. XmlSerializer
3. NetDataContractSerializer
4. BinaryFormatter

## Serializer

```C#
[DataContract]
public class Profile {
    [DataMember]
    public string UserName { get; set; }
    [DataMember]
    public int MMR { get; set; }
}

static class DraphonyExtension {
    static void Serialize(this ProfileInfo o) {
        // TODO: please complete
    }
}
```

1. DataContractJsonSerializer
2. NetDataContractSenalizer
3. XmlSerializer
4. BinaryFormatter

<details>
    <summary>Solution</summary>
    ```C#
    using System;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;

    namespace ConsoleApp4
    {
        [Serializable]
        public class Unit
        {
            public string Name { get; set; }
            public int HP { get; set; }
            public int Energy { get; set; }
            public int MineralCost { get; set; }
            public int GasCost { get; set; }
        }

        [DataContract]
        public class Profile
        {
            [DataMember]
            public string UserName { get; set; }
            [DataMember]
            public int MMR { get; set; }
        }

        public class Skin
        {
            public string UnitName { get; set; }
            public string SkinUri { get; set; }
        }


        static class DraphonyExtension
        {
            public static void Serialize<T>(this T o) where T : class
            {
                var formatter = new DataContractJsonSerializer(o.GetType());
                string path = Path.GetTempFileName();
                var stream = File.OpenWrite(path);

                formatter.WriteObject(stream, o);
                Console.WriteLine(path);
            }
        }

        class Program
        {
            static void Main() {
                var ultralisk = new Unit {
                    Energy = 0,
                    MineralCost = 300,
                    GasCost = 200,
                    HP = 500,
                    Name = "Ultralisk"
                };
                var profile = new Profile {
                    UserName = "ChaosPeon",
                    MMR = 150   // Rage rectangle
                };

                var skin = new Skin {
                    SkinUri = "3890423-23489234-2348923",
                    UnitName = "Ultralisk"
                };

                ultralisk.Serialize();
                profile.Serialize();
                skin.Serialize();
            }
        }
    }

    ```
</details>