using UnityEngine;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class BallInitializer : MonoBehaviour {
        private Rigidbody2D MyRb { get; set; }
        public float speed = 500f;

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

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Contains("Obstacle"))
            {
                SpawnHitParticles();
            }
        }

        private void SpawnHitParticles()
        {
            hitParticlesInstance = Instantiate(hitParticles, transform.position, Quaternion.identity);
        }
    }
}
