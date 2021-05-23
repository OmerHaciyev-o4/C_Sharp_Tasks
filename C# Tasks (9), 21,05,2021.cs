      string[] input = new string[6];

      for (int i = 0; i < 6; i++) { input[i] = Console.ReadLine(); }

      Dictionary<string, string> keyAndValue = new Dictionary<string, string>();
      keyAndValue.Add(input[0], input[1]);
      keyAndValue.Add(input[2], input[3]);
      keyAndValue.Add(input[4], input[5]);

      string returing = JsonConvert.SerializeObject(keyAndValue);

      File.WriteAllLines(@"result.json", new string[] { returing });


      string[] output = File.ReadAllLines(@"result.json");

      var line = output[0];

      var result = JsonConvert.DeserializeObject(line);

      Console.WriteLine(result);