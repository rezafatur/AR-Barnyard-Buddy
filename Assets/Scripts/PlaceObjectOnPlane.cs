using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class PlaceObjectOnPlane : MonoBehaviour {
    private ARPlaneManager planeManager;
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private bool objectPlaced = false;

    public GameObject placedPrefab;
    public GameObject canvas1;
    public GameObject canvas2;

    private void Awake() {
        planeManager = GetComponent<ARPlaneManager>();
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update() {
        if(Input.touchCount > 0 && !objectPlaced) {
            PlaceObject();
        }
    }

    private void PlaceObject() {
        Touch touch = Input.GetTouch(0);
        
        if(touch.phase == TouchPhase.Began && !IsPointerOverUIObject()) {
            if(raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon)) {
                Pose hitPose = hits[0].pose;
                Instantiate(placedPrefab, hitPose.position, hitPose.rotation);
                objectPlaced = true;
                canvas1.SetActive(false);
                canvas2.SetActive(true);
            }
        }
    }

    private bool IsPointerOverUIObject() {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

        return results.Count > 0;
    }
}
