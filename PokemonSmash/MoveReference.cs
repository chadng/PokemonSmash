﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonSmash.IronInterface;
using GLImp;
using System.Diagnostics;

namespace PokemonSmash {
	public class MoveInstance {
		public float Cooldown = 0;

		Move move;

		Stopwatch UpdateTimer = new Stopwatch();
		public MoveInstance(Move move) {
			this.move = move;

			UpdateTimer.Start();
			GraphicsManager.Update += new GraphicsManager.Updater(GraphicsManager_Update);
		}

		void GraphicsManager_Update() {
			float dt = UpdateTimer.ElapsedMilliseconds / 1000.0f;
			UpdateTimer.Restart();

			Cooldown -= dt;
		}

		public void OnUse(Player player) {
			if (Cooldown <= 0) {
				if (move != null && move.OnUse != null) {
					move.OnUse(player);
				}
			}
		}
	}
}
