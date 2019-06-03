using System.Collections.Generic;
using System.Linq;
using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Procedures;
using Kata.HospitalDomain.Scheduling;

namespace Kata.HospitalDomain
{
    public class Hospital
    {
        readonly List<IProcedureStrategy> _strategies;

        public Hospital()
        {
            _strategies = new List<IProcedureStrategy>
            {
                new LeftArmEmergencyAmputationStrategy(),
                new LeftArmAmputationStrategy(),
                new ToothPullStrategy(),
                new RightLegAmputationStrategy(),
            };
        }

        public TreatmentOutcome TreatIllness(string medicalCode, bool isEmergency = false)
        {
            var outcome = new TreatmentOutcome();
            _strategies
                .First(x => x.CanDoProcedure(medicalCode, isEmergency))
                .DoProcedure(outcome);
            return outcome;
        }

        public Appointment ScheduleProcedure(string medicalCode)
        {
            //how will we create this appointment?
            
            return new Appointment();
        }
    }
}