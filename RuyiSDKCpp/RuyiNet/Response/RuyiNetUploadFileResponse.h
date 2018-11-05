#pragma once

#include <string>

#include "../RuyiNetClient.h"

namespace Ruyi { namespace SDK { namespace Online {

	/// <summary>
	/// The response after uploading a file.
	/// </summary>
	struct RuyiNetUploadFileResponse
	{
		/// <summary>
		/// The response data.
		/// </summary>
		struct Data
		{
			/// <summary>
			/// The details of the file to upload.
			/// </summary>
			struct FileDetails
			{
				/// <summary>
				/// When the file was last updated.
				/// </summary>
				long updatedAt;
				/// <summary>
				/// The size of the file.
				/// </summary>
				int fileSize;
				/// <summary>
				/// The file type.
				/// </summary>
				std::string fileType;
				/// <summary>
				/// When the file expires.
				/// </summary>
				long expiresAt;
				/// <summary>
				/// Whether or not the file is shareable.
				/// </summary>
				bool shareable;
				/// <summary>
				/// Whether or not the file is shareable.
				/// </summary>
				std::string uploadId;
				/// <summary>
				/// When the file was created.
				/// </summary>
				long createdAt;
				/// <summary>
				/// The profile ID of the owning player.
				/// </summary>
				std::string profileId;
				/// <summary>
				/// The ID of the game the file relates to.
				/// </summary>
				std::string gameId;
				/// <summary>
				/// The path to the file.
				/// </summary>
				std::string path;
				/// <summary>
				/// The filename.
				/// </summary>
				std::string filename;
				/// <summary>
				/// Whether the file will replace a file if it already exists.
				/// </summary>
				bool replaceIfExists;
				/// <summary>
				/// The location of the file on the cloud.
				/// </summary>
				std::string cloudPath;
			};
			
			/// <summary>
			/// The details of the file to upload.
			/// </summary>
			FileDetails fileDetails;
		};
		
		/// <summary>
		/// The response data.
		/// </summary>
		Data data;
		/// <summary>
		/// The status of the response.
		/// </summary>
		int status;

		void parseJson(nlohmann::json& j)
		{
			if (!j["status"].is_null())
			{
				status = j["status"];
			}

			if (!j["data"].is_null())
			{
				nlohmann::json dataJson = j["data"];

				if (!dataJson.is_object()) return;

				if (!dataJson["fileDetails"].is_null())
				{
					nlohmann::json fileDetailsJson = dataJson["fileDetails"];
					
					if (!fileDetailsJson.is_object()) return;
					
					if (!fileDetailsJson["updatedAt"].is_null())
					{
						data.fileDetails.updatedAt = fileDetailsJson["updatedAt"];
					}
					if (!fileDetailsJson["fileSize"].is_null())
					{
						data.fileDetails.fileSize = fileDetailsJson["fileSize"];
					}
					if (!fileDetailsJson["fileType"].is_null())
					{
						data.fileDetails.fileType = fileDetailsJson["fileType"];
					}
					if (!fileDetailsJson["expiresAt"].is_null())
					{
						data.fileDetails.expiresAt = fileDetailsJson["expiresAt"];
					}
					if (!fileDetailsJson["shareable"].is_null())
					{
						data.fileDetails.shareable = fileDetailsJson["shareable"];
					}
					if (!fileDetailsJson["uploadId"].is_null())
					{
						data.fileDetails.uploadId = fileDetailsJson["uploadId"];
					}
					if (!fileDetailsJson["createdAt"].is_null())
					{
						data.fileDetails.createdAt = fileDetailsJson["createdAt"];
					}
					if (!fileDetailsJson["profileId"].is_null())
					{
						data.fileDetails.profileId = fileDetailsJson["profileId"];
					}
					if (!fileDetailsJson["gameId"].is_null())
					{
						data.fileDetails.gameId = fileDetailsJson["gameId"];
					}
					if (!fileDetailsJson["path"].is_null())
					{
						data.fileDetails.path = fileDetailsJson["path"];
					}
					if (!fileDetailsJson["filename"].is_null())
					{
						data.fileDetails.filename = fileDetailsJson["filename"];
					}
					if (!fileDetailsJson["replaceIfExists"].is_null())
					{
						data.fileDetails.replaceIfExists = fileDetailsJson["replaceIfExists"];
					}
					if (!fileDetailsJson["cloudPath"].is_null())
					{
						data.fileDetails.cloudPath = fileDetailsJson["cloudPath"];
					}
				}
			}
		}
	};

}}} 