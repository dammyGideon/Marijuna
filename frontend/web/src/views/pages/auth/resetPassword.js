// Package Block
import { useState } from 'react';
import { Link } from 'react-router-dom';
import { Spin, notification } from 'antd';

// Custom Compoent Block
import { Button, InputField, Footer } from '../../../components';
import { useNProgress } from '../../../utils/customHooks/use-ngProgress';

// Assets Block
import { Logo } from '../../../components/Logo';
import { validateEmail } from '../../../utils/helper';
import { forgetPassword } from '../../../services/auth';

const ResetPassword = () => {
  useNProgress();

  const [loader, setLoader] = useState(false);
  const [email, setEmail] = useState('');
  const [notificationMessage, setNotificationMessage] = useState('');
  const [requestSent, setRequestSent] = useState(false);
  const [isEmailValid, setIsEmailValid] = useState(true);

  const handleResetPassword = async (event) => {
    event.preventDefault();
    try {
      setLoader(true);
      const response = await forgetPassword({ email });
      if (response?.success) {
        notification.success({ message: response?.data?.message });
        setRequestSent(true);
        setLoader(false);
      } else {
        setNotificationMessage(response?.data?.message);
        setLoader(false);
      }
    } catch (error) {
      console.log('🚀 ~ handleResetPassword ~ error:', error);
      setLoader(false);
    }
  };

  const handleEmailChange = (e) => {
    const newEmail = e.target.value;
    setEmail(newEmail);
    setIsEmailValid(validateEmail(newEmail));
  };
  return (
    <div className="container">
      <div className="main-form">
        <div className="logo-icon">
          <Logo />
        </div>
        {requestSent ? (
          <>
            <h1 className="form-title">Password reset request received!</h1>
            <p className="instructions">
              We have received your password reset request. If an account with
              the email address you provided exists in our system, we will send
              you an email with instructions on how to reset your password. If
              you do not receive this email within twenty minutes, please
              contact HerbzHub’s Technical Support team for further assistance.
            </p>
            <Button className="button">
              <Link to="/signin">Return to Sign In</Link>
            </Button>
          </>
        ) : (
          <>
            <h1 className="form-title">Reset Password</h1>
            <p className="instructions">
              Enter your email to reset your password
            </p>
            {!isEmailValid && (
              <p className="error-notification">Invalid Email</p>
            )}
            {notificationMessage && (
              <p className="error-notification">{notificationMessage}</p>
            )}
            <InputField
              type="email"
              placeholder="Name@Work-Email.com"
              value={email}
              onChange={handleEmailChange}
            />
            <Button
              className="button"
              onClick={handleResetPassword}
              disabled={!email}
            >
              {loader ? <Spin /> : 'Reset Passowrd'}
            </Button>

            <p className="quick-login-link">
              <Link to={'/'}>Back to Sign In</Link>
            </p>
          </>
        )}
        <Footer />
      </div>
      <div className="auth-page-banner">
        {/* Background graphic goes here */}
      </div>
    </div>
  );
};

export default ResetPassword;
