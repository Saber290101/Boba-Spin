using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;
using UnityEngine.Serialization;

public class GameController : MonoBehaviour
{
    
    public GameObject Spin;
    public GameObject icePrefab;
    public GameObject topping1;
    public GameObject topping2;
    public GameObject topping3;
    public GameObject topping4;
    public GameObject topping5;
    public GameObject topping6;
    public GameObject topping7;
    public GameObject topping8;
    public GameObject topping9;
    public GameObject water;
    public GameObject scrollview, hoinuoc;
    public GameObject startUI;
    public AudioSource Drop;
    public List<GameObject> toppings = new List<GameObject>();
    public GameObject store;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        Destroy(Spin);
        StartCoroutine(Water());
    }

    IEnumerator Water()
    {
        yield return new WaitForSeconds(0f);
        water.transform.DOMoveY(6, 2f).OnComplete(() =>
        {
            startUI.SetActive(true);
            store.SetActive(true);
            hoinuoc.SetActive(true);
            TouchStart(); 
        });
    }
    private void TouchStart()
    {
        /*maskStart.SetActive(false);*/
        var rt = scrollview.GetComponent<RectTransform>();
        rt.DOSizeDelta(new Vector2(175, 640),0.5f);
        var pos = scrollview.GetComponent<RectTransform>();
        pos.DOLocalMove(new Vector3(-400, 440, 0), 0.5f);
    }
    
    public void InitTopping()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("ice", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),6f);
        var newList = Instantiate(icePrefab, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    public void InitTopping1()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("topping1", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping1, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    public void InitTopping2()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("topping2", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping2, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    public void InitTopping3()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("topping3", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping3, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    
    public void InitTopping4()
    {
        Drop.PlayDelayed(0.65f);
        /*hand.SetActive(false);*/
        Luna.Unity.Analytics.LogEvent("topping4", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping4, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    
    public void InitTopping5()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("topping5", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping5, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    
    public void InitTopping6()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("topping6", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping6, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    
    public void InitTopping7()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("topping7", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping7, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    
    public void InitTopping8()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("topping8", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping8, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }
    
    public void InitTopping9()
    {
        Drop.PlayDelayed(0.65f);
        Luna.Unity.Analytics.LogEvent("topping9", 0);
        var randomSpawnPos = new Vector3(Random.Range(-2f, 2.5f),4.7f);
        var newList = Instantiate(topping9, randomSpawnPos, Quaternion.Euler(0,0,Random.Range(0,90f)));
        toppings.Add(newList);
    }

    public void CTA()
    {
        Luna.Unity.Playable.InstallFullGame();
        Luna.Unity.LifeCycle.GameEnded();
        Luna.Unity.Analytics.LogEvent("Store", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
