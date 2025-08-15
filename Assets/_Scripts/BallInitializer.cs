using UnityEngine;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class BallInitializer : MonoBehaviour {
        private Rigidbody2D MyRb { get; set; }
        public float speed = 500f;

        //tutorial: https://youtu.be/0HKSvT2gcuk?feature=shared
        //the public hitParticles allows me to attach a particle effect prefab (in my case) to the ball, and the private hitParticlesInstance is used below
        public ParticleSystem hitParticles;
        private ParticleSystem hitParticlesInstance;

        private void Awake() {
            MyRb = GetComponent<Rigidbody2D>();
        }

        private void Start() {
            Invoke(nameof(SetRandomTrajectory), 1f);
        }

        private void SetRandomTrajectory() {
            Vector2 force = Vector2.zero;
            force.x = Random.Range(-0.5f, 0.5f);
            force.y = -1;
        
            MyRb.AddForce(force.normalized * speed);
        }

        //spawns particles if ball collides with an obstacle (will have "obstacle" in its name)
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Contains("Obstacle"))
            {
                SpawnHitParticles();
            }
        }

        //calls SpawnHitParticles to spawn hit particles. the particles are created with Instantiate at where the ball had been with transform.position. quaternion makes it not rotate
        private void SpawnHitParticles()
        {
            hitParticlesInstance = Instantiate(hitParticles, transform.position, Quaternion.identity);
        }
    }
}
