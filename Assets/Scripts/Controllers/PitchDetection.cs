using System.Linq;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class PitchDetection : MonoBehaviour
{


    [SerializeField] Lasp.SpectrumAnalyzer analyzer = null;
    [SerializeField] Lasp.AudioLevelTracker analyzerLevel = null;

    void Start()
    {

    }

    void Update()
    {
        var peak = analyzer.spectrumSpan.ToArray().Max();
        Debug.Log("Peak of spectrum: " + peak);

        var loudness = analyzerLevel.normalizedLevel;
        Debug.Log("Loudness: " + loudness);
    }



}