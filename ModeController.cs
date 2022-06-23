using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeeja_ImageLabeller
{
    internal class ModeController
    {
        private List<ProgramMode> modes;
        private ProgramMode activeMode;

        public ModeController(List<ProgramMode> modes)
        {
            if (modes.Count() < 1)
            {
                throw new ArgumentException("Mode list may not be empty");
            }
            this.modes = modes;
            activeMode = modes.First();
        }

        public void activateMode(int id)
        {
            foreach (ProgramMode item in modes) {
                item.switchActive(false);
            }
            modes[id].switchActive(true);
        }
    }
}
