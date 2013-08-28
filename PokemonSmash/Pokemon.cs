﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PokemonSmash {
	
	public class Pokemon {
		public string Name {
			get;
			private set;
		}
		public float HP;
		public float Attack;
		public float Defense;
		public float SpecialAttack;
		public float SpecialDefense;
		public float Speed;
		public string DisplayName;

		public float Width;
		public float Height;
		public float Weight;

		public bool CanJump = true;
		public bool CastsShadow = true;
		public bool Hovers = false;
		public Color Color = Color.Gray;

		public Move[] Move = new Move[4];
		public List<string> Moves = new List<string>();
		public List<MixItem> MixQueue = new List<MixItem>();
		Dictionary<string, string> AnimationAlias = new Dictionary<string, string>();
		
		public string Animation;


		public Pokemon(string Name) {
			this.Name = Name;
		}

		
		public void SetMix(string from, string to, float time){
			MixQueue.Add(new MixItem(from, to, time));
		}

		

		public void AddAnimationAlias(string from, string to) {
			AnimationAlias[from] = to;
		}

		public string FilterAnimationAlias(string from) {
			if (AnimationAlias.ContainsKey(from)) {
				return AnimationAlias[from];
			} else {
				return from;
			}
		}
	}
}
