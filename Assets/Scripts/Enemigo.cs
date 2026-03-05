using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    private Transform playerTransform;

    void Start()
    {
        
        navMeshAgent = GetComponent<NavMeshAgent>();

        playerTransform = FindAnyObjectByType<Jugador>().transform;

    }

    void Update()
    {
        navMeshAgent.destination = playerTransform.position;

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Vida>(out Vida scriptVida))
        {
            scriptVida.RecibirDano(1);
        }
    }
}
