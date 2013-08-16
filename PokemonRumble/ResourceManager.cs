﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spine;
using GLImp;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;
using System.IO;

namespace PokemonRumble {
	class ResourceManager {
		internal static void Initialize() {
			InitializeScripts();
		}

		private static void InitializeScripts() {
			ScriptEngine engine = Python.CreateEngine();

			ScriptScope scope = engine.Runtime.CreateScope();
			//scope.SetVariable("progress", ProgressModule.Instance);
			//scope.SetVariable("spawns", SpawnsModule.Instance);

			RecursivelyRunScriptsIn(@"Data\", engine, scope);			
		}

		private static void RecursivelyRunScriptsIn(string Location, ScriptEngine engine, ScriptScope scope) {
			foreach (string file in Directory.GetFiles(Location)) {
				if (Path.GetExtension(file) == ".py") {
					ScriptScope script = engine.ExecuteFile(file, scope);
					//PowerResult result1 = script.powerUpRack();
					//PowerResult result2 = script.powerDownRack();
				}
			}

			foreach (string Dir in Directory.GetDirectories(Location)) {
				RecursivelyRunScriptsIn(Dir, engine, scope);
			}
		}

		
		public static Texture Shadow = new Texture(@"Data\shadow.png");
	}
}
