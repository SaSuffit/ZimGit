
using Windows.Media.SpeechSynthesis;

var voices = SpeechSynthesizer.AllVoices;

/*
foreach ( var voice in voices.GetType().GetProperties())
{
	Console.WriteLine($"TYPE: {voice.GetType()}");
	foreach(var property in voice.GetType().GetProperties())
	{
	Console.WriteLine($"{property.Name}: {property.GetValue(voice)}");
	}
	Console.WriteLine();
}
*/

string ssml = File.ReadAllText("input.txt");


SpeechSynthesizer synth = new SpeechSynthesizer(); 

synth.Voice = voices[2];
synth.Options.AudioVolume = 0.4;
synth.Options.SpeakingRate = 0.79;

SpeechSynthesisStream stream = await synth.SynthesizeSsmlToStreamAsync(ssml);

using FileStream file = File.Create("output.wav");

await stream.AsStreamForRead().CopyToAsync(file);

Console.WriteLine("Created output.wav");

