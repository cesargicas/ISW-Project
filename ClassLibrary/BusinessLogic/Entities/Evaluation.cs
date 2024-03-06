﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities {
    public partial class Evaluation {
        public Evaluation() {}

        public Evaluation(DateTime EvaluationDate, string RejectionReason, Member Censor, Content Content) :this() {
            this.EvaluationDate = EvaluationDate;
            this.RejectionReason = RejectionReason;
            this.Censor = Censor;
            this.Content = Content;
        }
    }
}
