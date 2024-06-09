import { Button } from 'antd';
import { logoIcon, logoTextWhite } from '../../../utils/constant';
import { Link } from 'react-router-dom';

export default function onboardingCompleted() {
  return (
    <>
      <div className="loader">
        <img src={logoIcon} alt="HerbzHub Logo" width={150} />;
        <img src={logoTextWhite} alt="HerbzHub Logo" width={150} />;
        <p className="onboarding-complete">Onboarding Complete!</p>
        <p className="onboarding-messsage">
          Thank you for completing the onboarding. Please check your email for
          account setup confirmation.{' '}
        </p>
        <Button size="large" className="click-button">
          <Link to="/dashboard">Continue to Dashboard</Link>
        </Button>
      </div>
    </>
  );
}
