using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: ProjectCreator <project_name>");
            return;
        }

        string projectName = args[0];
        CreateProject(projectName);
        Console.WriteLine($"Project files and directories created for: {projectName}");
    }

    static void CreateProject(string projectName)
    {
        Directory.CreateDirectory(projectName);

        string[] directories = {
            "Blender/Asset",
            "Blender/ProjectFiles",

            "Video/VideoRaw",
            "Video/ImageSequence",
            "Video/RenderSequence",
            "Video/RenderOutput",
            
            "Audio/AudioRaw",
            "Audio/SoundEffects",
            "Audio/Music",
            "Audio/AudioOutput"
        };

        foreach (string dir in directories)
        {
            Directory.CreateDirectory(Path.Combine(projectName, dir));
        }

        File.WriteAllText(Path.Combine(projectName, "credits.txt"), "ProjectCredits");
        File.WriteAllText(Path.Combine(projectName, "config.txt"), "ConfigFileContents");
        File.WriteAllText(Path.Combine(projectName, "README.md"), $"# {projectName} Project");
    }
}
