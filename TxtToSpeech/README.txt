    /*********************************************************/
                          WELCOME

QUICK AND DIRTY TTS APP CREATED FOR FUN IN AN HOUR WITH ~some~ *AI INPUT* (YES AI, SORRY/NOT-SORRY)
    TAKES Ssml INSIDE 'input.txt' FOUND LOCALLY/RELATIVE TO PROGRAM.CS

-- PLEASE REVIEW HARDCODED VALUES AS THEY DO EFFECT THE SPEECH HEAVILY AND ARE PRETTY SELF EXPLANATORY

**TIP**
IF YOU WANT TO USE BARE TXT IN 'input.txt' THEN --
    string ssml = File.ReadAllText("input.txt");
  (...)
    SpeechSynthesisStream stream = await synth.SynthesizeSsmlToStreamAsync(ssml);

becomes:
        string text = File.ReadAllText("input.txt");
      (...)
        SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(text);


                    C.L. DOUGLAS SEPT/17/2026
    /*********************************************************/
