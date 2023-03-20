using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class FeatureSupported : MonoBehaviour
{
    [SerializeField]
    private Text features;

    [SerializeField]
    private ARFaceManager arFaceManager;

    [SerializeField]
    private ARHumanBodyManager arHumanBodyManager;

    [SerializeField]
    private ARPointCloudManager arPointCloudManager;

    void Start()
    {
        // Face Support Checks
        bool supportsEyeTracking = arFaceManager.descriptor.supportsEyeTracking;
        bool supportsFacePose = arFaceManager.descriptor.supportsFacePose;
        bool supportsFaceMeshVerticesAndIndices = arFaceManager.descriptor.supportsFaceMeshVerticesAndIndices;

        // Human Body Support Checks
        bool supportsHumanBody2D = arHumanBodyManager.descriptor.supportsHumanBody2D;
        bool supportsHumanBody3D = arHumanBodyManager.descriptor.supportsHumanBody3D;
        //bool supportsHumanDepthImage = arHumanBodyManager.descriptor.supportsHumanDepthImage;
        bool supportsHumanDepthImage = arHumanBodyManager.descriptor.supportsHumanBody3DScaleEstimation;

        // Point Cloud Support Checks
        bool supportsConfidence = arPointCloudManager.descriptor.supportsConfidence;
        bool supportsFeaturePoints = arPointCloudManager.descriptor.supportsFeaturePoints;
        
        features.text = $"supportsEyeTracking : {supportsEyeTracking}\n" +
            $"supportsFacePose : {supportsFacePose}\n" +
            $"supportsFaceMeshVerticesAndIndices : {supportsFaceMeshVerticesAndIndices}\n" +
            $"supportsHumanBody2D : {supportsHumanBody2D}\n" +
            $"supportsHumanBody3D : {supportsHumanBody3D}\n" +
            $"supportsHumanDepthImage : {supportsHumanDepthImage}\n" +
            $"supportsConfidence : {supportsConfidence}\n" +
            $"supportsFeaturePoints : {supportsFeaturePoints}";
    }
}
