using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentParams : MonoBehaviour
{
    public static VisType currentVisType = VisType.Scatterplot; // default
    public static BinningType currentBinningType = BinningType.Squareroot; // default
    public static Dictionary<string, double[]> loadedData = null; // default
    public static double kdeSigmaValue = 1; // default
    public static int kdeStepsValue = 100; // default

}
