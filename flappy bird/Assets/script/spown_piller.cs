using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spown_piller : MonoBehaviour
{
    [SerializeField] private float speed;//---\
    [SerializeField] private float bound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= Vector3.right * speed * Time.deltaTime;

        //if (this.transform.position.x < bound)
        //{
        //    Destroy(this.gameObject);
        //}
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(2);
    }
}
