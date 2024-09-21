using Enemy.MelEnemy;

namespace Enemy.Boss.MiniBoss.State
{
    public class LandAttackState : IStateClass
    {
        public MiniBossEnemy _MiniBossEnemy;

        public LandAttackState(MiniBossEnemy _miniBossEnemy)
        {
            _MiniBossEnemy = _miniBossEnemy;
        }

        public void Enter()
        {
            _MiniBossEnemy._isAttacking = true;
            _MiniBossEnemy.LandAttackPatternStart();
        }

        public void Update()
        {
            
        }

        public void Exit()
        {
            
        }
    }
}