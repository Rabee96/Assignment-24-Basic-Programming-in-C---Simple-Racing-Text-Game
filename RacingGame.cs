using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class RacingGame : MonoBehaviour
    {
        public RaceState raceState;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            SimulateRace(raceState);
        }
        void SimulateRace(RaceState state){
            switch (state)
            {
                case RaceState.Start:
                    Debug.Log("START...🔴🏎️🏁");
                    break;
                case RaceState.Accelerate:
                    Debug.Log("Need for Speed...🔥🏎️🏁");
                    break;
                case RaceState.Turn:
                    Debug.Log("Take the next Turn...⤴️🏎️🏁");
                    break;
                case RaceState.Crash:
                    Debug.Log("Crash go OUT...💥🏎️🏁");
                    break;
                case RaceState.Finish:
                    Debug.Log("Finish...🏆🥇🏁");
                    break;
                default:
                    Debug.Log("Ready...🟡🏁");
                    break;
            }
        }
    }
}
