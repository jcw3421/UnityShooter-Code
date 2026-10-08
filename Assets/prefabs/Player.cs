using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int Health = 200; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool Damage(int dma)
    {
        Health -= dma;
        if(Health <= 0)
        {
            return false;
        }

        return true;
    }
}
