// Autogenerated by Thrift Compiler (0.11.0)
// DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING

#![allow(unused_imports)]
#![allow(unused_extern_crates)]
#![cfg_attr(feature = "cargo-clippy", allow(too_many_arguments, type_complexity))]
#![cfg_attr(rustfmt, rustfmt_skip)]

extern crate ordered_float;
extern crate thrift;
extern crate try_from;

use ordered_float::OrderedFloat;
use std::cell::RefCell;
use std::collections::{BTreeMap, BTreeSet};
use std::convert::From;
use std::default::Default;
use std::error::Error;
use std::fmt;
use std::fmt::{Display, Formatter};
use std::rc::Rc;
use try_from::TryFrom;

use thrift::{ApplicationError, ApplicationErrorKind, ProtocolError, ProtocolErrorKind, TThriftClient};
use thrift::protocol::{TFieldIdentifier, TListIdentifier, TMapIdentifier, TMessageIdentifier, TMessageType, TInputProtocol, TOutputProtocol, TSetIdentifier, TStructIdentifier, TType};
use thrift::protocol::field_id;
use thrift::protocol::verify_expected_message_type;
use thrift::protocol::verify_expected_sequence_number;
use thrift::protocol::verify_expected_service_call;
use thrift::protocol::verify_required_field_exists;
use thrift::server::TProcessor;

use speech_service_s_d_k_data_types;

//
// SpeechService service client
//

pub trait TSpeechServiceSyncClient {
  fn say(&mut self, command: speech_service_s_d_k_data_types::VoiceCommand) -> thrift::Result<speech_service_s_d_k_data_types::SpeechResult>;
}

pub trait TSpeechServiceSyncClientMarker {}

pub struct SpeechServiceSyncClient<IP, OP> where IP: TInputProtocol, OP: TOutputProtocol {
  _i_prot: IP,
  _o_prot: OP,
  _sequence_number: i32,
}

impl <IP, OP> SpeechServiceSyncClient<IP, OP> where IP: TInputProtocol, OP: TOutputProtocol {
  pub fn new(input_protocol: IP, output_protocol: OP) -> SpeechServiceSyncClient<IP, OP> {
    SpeechServiceSyncClient { _i_prot: input_protocol, _o_prot: output_protocol, _sequence_number: 0 }
  }
}

impl <IP, OP> TThriftClient for SpeechServiceSyncClient<IP, OP> where IP: TInputProtocol, OP: TOutputProtocol {
  fn i_prot_mut(&mut self) -> &mut TInputProtocol { &mut self._i_prot }
  fn o_prot_mut(&mut self) -> &mut TOutputProtocol { &mut self._o_prot }
  fn sequence_number(&self) -> i32 { self._sequence_number }
  fn increment_sequence_number(&mut self) -> i32 { self._sequence_number += 1; self._sequence_number }
}

impl <IP, OP> TSpeechServiceSyncClientMarker for SpeechServiceSyncClient<IP, OP> where IP: TInputProtocol, OP: TOutputProtocol {}

impl <C: TThriftClient + TSpeechServiceSyncClientMarker> TSpeechServiceSyncClient for C {
  fn say(&mut self, command: speech_service_s_d_k_data_types::VoiceCommand) -> thrift::Result<speech_service_s_d_k_data_types::SpeechResult> {
    (
      {
        self.increment_sequence_number();
        let message_ident = TMessageIdentifier::new("Say", TMessageType::Call, self.sequence_number());
        let call_args = SayArgs { command: command };
        self.o_prot_mut().write_message_begin(&message_ident)?;
        call_args.write_to_out_protocol(self.o_prot_mut())?;
        self.o_prot_mut().write_message_end()?;
        self.o_prot_mut().flush()
      }
    )?;
    {
      let message_ident = self.i_prot_mut().read_message_begin()?;
      verify_expected_sequence_number(self.sequence_number(), message_ident.sequence_number)?;
      verify_expected_service_call("Say", &message_ident.name)?;
      if message_ident.message_type == TMessageType::Exception {
        let remote_error = thrift::Error::read_application_error_from_in_protocol(self.i_prot_mut())?;
        self.i_prot_mut().read_message_end()?;
        return Err(thrift::Error::Application(remote_error))
      }
      verify_expected_message_type(TMessageType::Reply, message_ident.message_type)?;
      let result = SayResult::read_from_in_protocol(self.i_prot_mut())?;
      self.i_prot_mut().read_message_end()?;
      result.ok_or()
    }
  }
}

//
// SpeechService service processor
//

pub trait SpeechServiceSyncHandler {
  fn handle_say(&self, command: speech_service_s_d_k_data_types::VoiceCommand) -> thrift::Result<speech_service_s_d_k_data_types::SpeechResult>;
}

pub struct SpeechServiceSyncProcessor<H: SpeechServiceSyncHandler> {
  handler: H,
}

impl <H: SpeechServiceSyncHandler> SpeechServiceSyncProcessor<H> {
  pub fn new(handler: H) -> SpeechServiceSyncProcessor<H> {
    SpeechServiceSyncProcessor {
      handler: handler,
    }
  }
  fn process_say(&self, incoming_sequence_number: i32, i_prot: &mut TInputProtocol, o_prot: &mut TOutputProtocol) -> thrift::Result<()> {
    TSpeechServiceProcessFunctions::process_say(&self.handler, incoming_sequence_number, i_prot, o_prot)
  }
}

pub struct TSpeechServiceProcessFunctions;

impl TSpeechServiceProcessFunctions {
  pub fn process_say<H: SpeechServiceSyncHandler>(handler: &H, incoming_sequence_number: i32, i_prot: &mut TInputProtocol, o_prot: &mut TOutputProtocol) -> thrift::Result<()> {
    let args = SayArgs::read_from_in_protocol(i_prot)?;
    match handler.handle_say(args.command) {
      Ok(handler_return) => {
        let message_ident = TMessageIdentifier::new("Say", TMessageType::Reply, incoming_sequence_number);
        o_prot.write_message_begin(&message_ident)?;
        let ret = SayResult { result_value: Some(handler_return) };
        ret.write_to_out_protocol(o_prot)?;
        o_prot.write_message_end()?;
        o_prot.flush()
      },
      Err(e) => {
        match e {
          thrift::Error::Application(app_err) => {
            let message_ident = TMessageIdentifier::new("Say", TMessageType::Exception, incoming_sequence_number);
            o_prot.write_message_begin(&message_ident)?;
            thrift::Error::write_application_error_to_out_protocol(&app_err, o_prot)?;
            o_prot.write_message_end()?;
            o_prot.flush()
          },
          _ => {
            let ret_err = {
              ApplicationError::new(
                ApplicationErrorKind::Unknown,
                e.description()
              )
            };
            let message_ident = TMessageIdentifier::new("Say", TMessageType::Exception, incoming_sequence_number);
            o_prot.write_message_begin(&message_ident)?;
            thrift::Error::write_application_error_to_out_protocol(&ret_err, o_prot)?;
            o_prot.write_message_end()?;
            o_prot.flush()
          },
        }
      },
    }
  }
}

impl <H: SpeechServiceSyncHandler> TProcessor for SpeechServiceSyncProcessor<H> {
  fn process(&self, i_prot: &mut TInputProtocol, o_prot: &mut TOutputProtocol) -> thrift::Result<()> {
    let message_ident = i_prot.read_message_begin()?;
    let res = match &*message_ident.name {
      "Say" => {
        self.process_say(message_ident.sequence_number, i_prot, o_prot)
      },
      method => {
        Err(
          thrift::Error::Application(
            ApplicationError::new(
              ApplicationErrorKind::UnknownMethod,
              format!("unknown method {}", method)
            )
          )
        )
      },
    };
    thrift::server::handle_process_result(&message_ident, res, o_prot)
  }
}

//
// SayArgs
//

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd)]
struct SayArgs {
  command: speech_service_s_d_k_data_types::VoiceCommand,
}

impl SayArgs {
  fn read_from_in_protocol(i_prot: &mut TInputProtocol) -> thrift::Result<SayArgs> {
    i_prot.read_struct_begin()?;
    let mut f_1: Option<speech_service_s_d_k_data_types::VoiceCommand> = None;
    loop {
      let field_ident = i_prot.read_field_begin()?;
      if field_ident.field_type == TType::Stop {
        break;
      }
      let field_id = field_id(&field_ident)?;
      match field_id {
        1 => {
          let val = speech_service_s_d_k_data_types::VoiceCommand::read_from_in_protocol(i_prot)?;
          f_1 = Some(val);
        },
        _ => {
          i_prot.skip(field_ident.field_type)?;
        },
      };
      i_prot.read_field_end()?;
    }
    i_prot.read_struct_end()?;
    verify_required_field_exists("SayArgs.command", &f_1)?;
    let ret = SayArgs {
      command: f_1.expect("auto-generated code should have checked for presence of required fields"),
    };
    Ok(ret)
  }
  fn write_to_out_protocol(&self, o_prot: &mut TOutputProtocol) -> thrift::Result<()> {
    let struct_ident = TStructIdentifier::new("Say_args");
    o_prot.write_struct_begin(&struct_ident)?;
    o_prot.write_field_begin(&TFieldIdentifier::new("command", TType::Struct, 1))?;
    self.command.write_to_out_protocol(o_prot)?;
    o_prot.write_field_end()?;
    o_prot.write_field_stop()?;
    o_prot.write_struct_end()
  }
}

//
// SayResult
//

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd)]
struct SayResult {
  result_value: Option<speech_service_s_d_k_data_types::SpeechResult>,
}

impl SayResult {
  fn read_from_in_protocol(i_prot: &mut TInputProtocol) -> thrift::Result<SayResult> {
    i_prot.read_struct_begin()?;
    let mut f_0: Option<speech_service_s_d_k_data_types::SpeechResult> = None;
    loop {
      let field_ident = i_prot.read_field_begin()?;
      if field_ident.field_type == TType::Stop {
        break;
      }
      let field_id = field_id(&field_ident)?;
      match field_id {
        0 => {
          let val = speech_service_s_d_k_data_types::SpeechResult::read_from_in_protocol(i_prot)?;
          f_0 = Some(val);
        },
        _ => {
          i_prot.skip(field_ident.field_type)?;
        },
      };
      i_prot.read_field_end()?;
    }
    i_prot.read_struct_end()?;
    let ret = SayResult {
      result_value: f_0,
    };
    Ok(ret)
  }
  fn write_to_out_protocol(&self, o_prot: &mut TOutputProtocol) -> thrift::Result<()> {
    let struct_ident = TStructIdentifier::new("SayResult");
    o_prot.write_struct_begin(&struct_ident)?;
    if let Some(ref fld_var) = self.result_value {
      o_prot.write_field_begin(&TFieldIdentifier::new("result_value", TType::I32, 0))?;
      fld_var.write_to_out_protocol(o_prot)?;
      o_prot.write_field_end()?;
      ()
    } else {
      ()
    }
    o_prot.write_field_stop()?;
    o_prot.write_struct_end()
  }
  fn ok_or(self) -> thrift::Result<speech_service_s_d_k_data_types::SpeechResult> {
    if self.result_value.is_some() {
      Ok(self.result_value.unwrap())
    } else {
      Err(
        thrift::Error::Application(
          ApplicationError::new(
            ApplicationErrorKind::MissingResult,
            "no result received for Say"
          )
        )
      )
    }
  }
}

