/* src/views/Onboarding.js */

// Package Block
import { useState, useEffect } from 'react';
import { Link, useNavigate } from 'react-router-dom';

// Custom Components Block
import {
  CountyForm,
  OrganizationTypeForm,
  PocForm,
  SerialNumberForm,
  LicensingForm,
  OrganizationForm,
  CredentialsForm,
  CompletionStep,
  ReviewStep,
} from '../../../components';

// Assets & Utilites function
import { logoText, logoIcon } from '../../../utils/constant';
import { useNProgress } from '../../../utils/customHooks/use-ngProgress';
import { onboardingNewUser } from '../../../services/auth';
import { notification } from 'antd';

const Onboarding = () => {
  useNProgress();
  const navigate = useNavigate();
  const [serialNumber, setSerialNumber] = useState('');
  console.log('🚀 ~ Onboarding ~ serialNumber:', serialNumber);
  const [step, setStep] = useState(1);
  const [formData, setFormData] = useState({
    roleId: '',
    countiesId: '',
    serialNumber: '',
    firstName: '',
    lastName: '',
    email: '',
    phoneNumber: '',
    streetAddress: '',
    usersCity: '',
    usersState: '',
    usersZipCode: '',
    password: '',
    confirmPassword: '',
    stateLicense: '',
    businessName: '',
    businessAddress: '',
    businessCity: '',
    businessState: '',
    businessZipCode: '',
    businessContact: '',
    businessEmail: '',
    businessEIN: '',
  });

  const [stateLicenseStatus, setStateLicenseStatus] = useState('ready');

  const handleOrganizationTypeSubmit = (event) => {
    event.preventDefault();
    setStep(2);
  };

  const handleCountySubmit = (event) => {
    event.preventDefault();
    setStep(3);
  };

  const handleSerialNumberSubmit = (event) => {
    event.preventDefault();
    setStep(4);
  };

  const handlePocFormSubmit = (event) => {
    event.preventDefault();
    setStep(5);
  };

  const handleLicensingFormSubmit = (event) => {
    event.preventDefault();
    setStep(6);
  };

  const handleOrganizationFormSubmit = (event) => {
    event.preventDefault();
    setStep(7);
  };

  const handleCredentialsSubmit = (event) => {
    event.preventDefault();
    setStep(8); // Move to the review step
  };

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value,
    });
    if (name === 'serialNumber') {
      setSerialNumber(value);
    }
  };

  useEffect(() => {
    const validateLicense = async (licenseNumber, setStatus) => {
      if (!licenseNumber) return;
      setStatus('loading');

      setTimeout(() => {
        if (licenseNumber === 'VALID') {
          setStatus('valid');
        } else {
          setStatus('invalid');
        }
      }, 2000);
    };

    validateLicense(formData.stateLicenseNumber, setStateLicenseStatus);
  }, [formData.federalLicenseNumber, formData.stateLicenseNumber]);

  const handleReviewSubmit = async (event) => {
    event.preventDefault();

    // Making payload ready to integrate
    const transformedPayload = {
      roleId: formData.roleId,
      countiesId: formData.countiesId,
      serialNumber: formData.serialNumber,
      password: formData.password,
      confirmPassword: formData.confirmPassword,
      firstName: formData.firstName,
      lastName: formData.lastName,
      email: formData.email,
      phoneNumber: formData.phoneNumber,
      addressRequest: {
        streetAddress: formData.streetAddress,
        usersCity: formData.usersCity,
        usersState: formData.usersState,
        usersZipCode: formData.usersZipCode,
      },
      stateLicense: formData.stateLicense,
      businessDetails: {
        businessName: formData.businessName,
        businessEIN: formData.businessEIN,
        businessEmail: formData.businessEmail,
        businessContact: formData.businessContact,
        businessAddress: formData.businessAddress,
        businessCity: formData.businessCity,
        businessState: formData.businessState,
        businessZipCode: formData.businessZipCode,
      },
    };
    try {
      const response = await onboardingNewUser(transformedPayload);
      if (response.data.success) {
        notification.success({ message: response.data.message });
        navigate('/congratulations-onboarding-completed');
      }
    } catch (error) {
      console.log('🚀 ~ handleReviewSubmit ~ error:', error);
    }
    console.log(transformedPayload);
    alert(JSON.stringify(transformedPayload, null, 2));
  };

  useEffect(() => {
    // console.log('Current Step:', step);
  }, [step]);

  return (
    <div className="onboarding-page">
      <div className="header">
        <div className="logo-text">
          <img src={logoText} alt="HerbzHub Text Logo" />
        </div>
        <div className="sign-in-link">
          Already have an account?&nbsp;<Link to="/signin"> Sign In.</Link>
        </div>
      </div>
      <div className="onboarding-form">
        <div className="logo-top">
          <img src={logoIcon} alt="HerbzHub Logo" />
        </div>
        <h1 className="form-title">Welcome to HerbzHub!</h1>
        {step === 1 && (
          <>
            <p className="form-subtitle">Select your organization's Type.</p>
            <OrganizationTypeForm
              handleInputChange={handleInputChange}
              formData={formData}
              handleSubmit={handleOrganizationTypeSubmit}
            />
          </>
        )}
        {step === 2 && (
          <CountyForm
            formData={formData}
            handleInputChange={handleInputChange}
            handleSubmit={handleCountySubmit}
          />
        )}
        {step === 3 && (
          <SerialNumberForm
            formData={formData}
            handleInputChange={handleInputChange}
            handleSubmit={handleSerialNumberSubmit}
          />
        )}
        {step === 4 && (
          <PocForm
            formData={formData}
            handleInputChange={handleInputChange}
            handleSubmit={handlePocFormSubmit}
          />
        )}
        {step === 5 && (
          <LicensingForm
            formData={formData}
            handleInputChange={handleInputChange}
            handleLicenseFileChange={handleInputChange}
            stateLicenseStatus={stateLicenseStatus}
            handleSubmit={handleLicensingFormSubmit}
          />
        )}
        {step === 6 && (
          <OrganizationForm
            formData={formData}
            handleInputChange={handleInputChange}
            handleSubmit={handleOrganizationFormSubmit}
          />
        )}
        {step === 7 && (
          <CredentialsForm
            formData={formData}
            handleInputChange={handleInputChange}
            handleSubmit={handleCredentialsSubmit}
          />
        )}
        {step === 8 && (
          <ReviewStep
            formData={formData}
            handleInputChange={handleInputChange}
            handleSubmit={handleReviewSubmit}
            setStep={setStep} // Make sure to pass setStep to navigate between steps
          />
        )}
        {step === 9 && <CompletionStep />}
      </div>
    </div>
  );
};

export default Onboarding;
